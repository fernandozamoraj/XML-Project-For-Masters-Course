using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public class ProductGraph : IXmlSerializable
    {
        public Catalog Catalog{ get; set;}
        public Inventory Inventory { get; set; }
        public List<Vendor> Suppliers { get; set; }

        public ProductGraph()
        {
            this.Catalog = new Catalog();
            this.Inventory = new Inventory();
            Suppliers = new List<Vendor>();
        }

        public List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;

            if(includeRootElement)
            {
                xml.Add("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                xml.Add(leftPadding + "<ProductGraph xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"products.xsd\">");
            }

            xml.AddRange(Catalog.ProduceXml(innerPadding, true));
            xml.AddRange(Inventory.ProduceXml(innerPadding, true));

            xml.AddRange( Suppliers.ProduceXml(innerPadding, "Suppliers") );

            if(includeRootElement)
            {
                xml.Add(leftPadding + "</ProductGraph>");
            }

            return xml;
        }

        public void LoadFromXml(XElement xElement)
        {
            xElement.LoadObjectFromXml(Catalog, "Catalog");
            xElement.LoadObjectFromXml(Inventory, "Inventory");

            Suppliers = new List<Vendor>();

            foreach (XElement suppliersElement in xElement.Elements("Suppliers"))
            {
                foreach (XElement vendorElement in suppliersElement.Elements("Vendor"))
                {
                    Vendor vendor = new Vendor();
                    vendor.LoadFromXml(vendorElement);
                    Suppliers.Add(vendor);
                }
            }

            SetVendors();
            SetInventoryItems();
        }

        void SetVendors()
        {
            foreach(CatalogItem catalogItem in this.Catalog.BoxedItems)
            {
                catalogItem.Supplier = FindVendor(catalogItem.VendorId);
            }

            foreach (CatalogItem catalogItem in this.Catalog.VolumeItems)
            {
                catalogItem.Supplier = FindVendor(catalogItem.VendorId);
            }

            foreach (CatalogItem catalogItem in this.Catalog.CatalogItems)
            {
                catalogItem.Supplier = FindVendor(catalogItem.VendorId);
            }
        }

        void SetInventoryItems()
        {
            foreach (InventoryItem inventoryItem in Inventory.InventoryItems)
            {
                string catalogId = inventoryItem.CatalogItemId;
                string locationId = inventoryItem.LocationId;

                inventoryItem.CatalogItem = FindCatalogItem(catalogId) ?? new CatalogItem();

                inventoryItem.Location 
                    = Inventory.Locations.Find(location => location.Id == locationId) ??
                    new Location();
            }
        }

        CatalogItem FindCatalogItem(string catalogItemId)
        {
            CatalogItem returnItem = null;

            returnItem = Catalog.CatalogItems.Find(catalogItem => catalogItem.Id == catalogItemId);

            if (returnItem == null)
            {
                returnItem = Catalog.BoxedItems.Find(boxedItem => boxedItem.Id == catalogItemId);
            }

            if (returnItem == null)
            {
                returnItem = Catalog.VolumeItems.Find(volumeItem => volumeItem.Id == catalogItemId);
            }

            return returnItem;
        }

        Vendor FindVendor(string id)
        {
            foreach(Vendor vendor in this.Suppliers)
            {
                if(vendor.Id == id)
                {
                    return vendor;
                }
            }

            return new Vendor{Addresses = new List<Address>{new Address()}, Name = "Undetermined"};
        }


        public static ProductGraph FromFile(string filePath)
        {
            ProductGraph productGraph = new ProductGraph();

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                XDocument document = XDocument.Parse(streamReader.ReadToEnd());

                productGraph.LoadFromXml(document.Element("ProductGraph"));
            }

            return productGraph;
        }

        public void SaveToFile(string filePath)
        {
            List<string> xml = ProduceXml("", true);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in xml)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public void RemoveVendor(Vendor vendor)
        {
            List<InventoryItem> inventoryItemsToDelete = GetInventoryItemsForVendor(vendor);
            List<CatalogItem> catalogItemsToDelete = GetCatalogItemsForVendor(vendor);

            DeleteInventory(inventoryItemsToDelete);
            DeleteCatalog(catalogItemsToDelete);
            Suppliers.Remove(vendor);

        }

        public void RemoveCatalogItem(CatalogItem catalogItem)
        {
            List<InventoryItem> inventoryItemsToDelete = GetInventoryItemsForCatalog(catalogItem);

            DeleteInventory(inventoryItemsToDelete);
            DeleteCatalog(new List<CatalogItem>{catalogItem});
        }

        public void RemoveInventoryItem(InventoryItem inventoryItem)
        {
            DeleteInventory(new List<InventoryItem>{inventoryItem});
        }

        List<InventoryItem> GetInventoryItemsForCatalog(CatalogItem item)
        {
            List<InventoryItem> inventoryItems = new List<InventoryItem>();

            foreach(InventoryItem inventoryItem in Inventory.InventoryItems)
            {
                if (inventoryItem.CatalogItem.GetType() == item.GetType() &&
                    inventoryItem.CatalogItem.Equals(item))
                {
                    inventoryItems.Add(inventoryItem);
                }
            }

            return inventoryItems;
        }

        void DeleteCatalog(List<CatalogItem> deleteList)
        {
            foreach (CatalogItem catalogItem in deleteList)
            {
                
                if (catalogItem is BoxedItem)
                {
                    Catalog.BoxedItems.Remove((BoxedItem)catalogItem);
                }
                else if (catalogItem is VolumeItem)
                {
                    Catalog.VolumeItems.Remove((VolumeItem)catalogItem);
                }
                else
                {
                    Catalog.CatalogItems.Remove(catalogItem);
                }
            }
        }

        void DeleteInventory(List<InventoryItem> deleteList)
        {
            foreach (InventoryItem inventoryItem in deleteList)
            {
                Inventory.InventoryItems.Remove(inventoryItem);
                
            }
        }

        private List<InventoryItem> GetInventoryItemsForVendor(Vendor vendor)
        {
            List<InventoryItem> inventoryItems = new List<InventoryItem>();

            foreach (InventoryItem inventoryItem in Inventory.InventoryItems)
            {
                if (inventoryItem.CatalogItem.Supplier.Equals(vendor))
                {
                    inventoryItems.Add(inventoryItem);
                }
            }

            return inventoryItems;
        }

        private List<CatalogItem> GetCatalogItemsForVendor(Vendor vendor)
        {
            List<CatalogItem> catalogItems = new List<CatalogItem>();

            foreach (CatalogItem catalogItem in Catalog.BoxedItems)
            {
                if (catalogItem.Supplier.Equals(vendor))
                {
                    catalogItems.Add(catalogItem);
                }
            }

            foreach (CatalogItem catalogItem in Catalog.VolumeItems)
            {
                if (catalogItem.Supplier.Equals(vendor))
                {
                    catalogItems.Add(catalogItem);
                }
            }

            foreach (CatalogItem catalogItem in Catalog.CatalogItems)
            {
                if (catalogItem.Supplier.Equals(vendor))
                {
                    catalogItems.Add(catalogItem);
                }
            }

            return catalogItems;
        }
    }
}