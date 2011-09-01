using System;
using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public class Catalog : IXmlSerializable
    {
        public List<BoxedItem> BoxedItems { get; set; }
        public List<VolumeItem> VolumeItems { get; set; }
        public List<CatalogItem> CatalogItems { get; set; }
        
        public Catalog()
        {
            CatalogItems = new List<CatalogItem>();
            VolumeItems = new List<VolumeItem>();
            BoxedItems = new List<BoxedItem>();
        }

        public List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;
            if(includeRootElement)
            {
                xml.Add(leftPadding + "<Catalog>");
            }

            xml.AddRange(CatalogItems.ProduceXml(innerPadding, "CatalogItems"));
            xml.AddRange(BoxedItems.ProduceXml(innerPadding, "BoxedItems"));
            xml.AddRange(VolumeItems.ProduceXml(innerPadding, "VolumeItems"));

            if(includeRootElement)
            {
                xml.Add(leftPadding + "</Catalog>");
            }

            return xml;
        }

        public void LoadFromXml(XElement xElement)
        {
            CatalogItems = new List<CatalogItem>();

            foreach (XElement catalogElements in xElement.Elements("CatalogItems"))
            {
                foreach (XElement catalogItemElement in catalogElements.Elements("CatalogItem") )
                {
                    CatalogItem newItem = new CatalogItem();

                    newItem.LoadFromXml(catalogItemElement);

                    CatalogItems.Add(newItem);
                }
            }

            foreach (XElement catalogElements in xElement.Elements("BoxedItems"))
            {
                foreach (XElement catalogElement in catalogElements.Elements("BoxedItem"))
                {
                    BoxedItem newItem = new BoxedItem();

                    newItem.LoadFromXml(catalogElement);

                    BoxedItems.Add(newItem);
                }
            }

            foreach (XElement catalogElements in xElement.Elements("VolumeItems"))
            {
                foreach (XElement catalogElement in catalogElements.Elements("VolumeItem"))
                {
                    VolumeItem newItem = new VolumeItem();

                    newItem.LoadFromXml(catalogElement);

                    VolumeItems.Add(newItem);
                }
            }
        }

        public void RemoveItem(CatalogItem item)
        {
            if(item is BoxedItem)
            {
                BoxedItems.Remove((BoxedItem)item);
            }
            else if(item is VolumeItem)
            {
                VolumeItems.Remove((VolumeItem)item);
            }
            else
            {
                CatalogItems.Remove(item);
            }
        }

        public void AddItem(CatalogItem item)
        {
            if (item is BoxedItem)
            {
                BoxedItems.Add((BoxedItem)item);
            }
            else if (item is VolumeItem)
            {
                VolumeItems.Add((VolumeItem)item);
            }
            else
            {
                CatalogItems.Add(item);
            }
        }

        public bool Contains(Vendor vendor, string vendorAssignedProductId)
        {
            foreach (var catalogItem in GetAllCatalogItems())
            {
                if(catalogItem.Supplier.Equals(vendor) &&
                    catalogItem.VendorAssignedProductId.Equals(vendorAssignedProductId))
                {
                    return true;
                }
            }

            return false;
        }

        List<CatalogItem> GetAllCatalogItems()
        {
            List<CatalogItem> allCatalogItems = new List<CatalogItem>();

            foreach (CatalogItem catalogItem in CatalogItems)
            {
                allCatalogItems.Add(catalogItem);
            }

            foreach (CatalogItem catalogItem in BoxedItems)
            {
                allCatalogItems.Add(catalogItem);
            }

            foreach (CatalogItem catalogItem in VolumeItems)
            {
                allCatalogItems.Add(catalogItem);
            }

            return allCatalogItems;

        }

        public bool IsValidProductId(Vendor vendor, string catalogId, string vendorAssignedProductId)
        {
            CatalogItem catalogItem = GetAllCatalogItems().Find(
                x =>
                x.Id != catalogId && 
                x.VendorAssignedProductId == vendorAssignedProductId && 
                x.Supplier.Equals(vendor));

            return catalogItem == null;
            
        }
    }
}
