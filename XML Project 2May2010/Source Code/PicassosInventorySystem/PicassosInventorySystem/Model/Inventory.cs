using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public class Inventory : IXmlSerializable
    {
        public List<InventoryItem> InventoryItems { get; set; }
        public List<Location> Locations { get; set; }

        public Inventory()
        {
            InventoryItems = new List<InventoryItem>();
            Locations = new List<Location>();
        }

        public List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;

            if(includeRootElement)
            {
                xml.Add(leftPadding + "<Inventory>");    
            }

            xml.AddRange(InventoryItems.ProduceXml(innerPadding, "InventoryItems"));
            xml.AddRange(Locations.ProduceXml(innerPadding, "Locations"));
            
            if (includeRootElement)
            {
                xml.Add(leftPadding + "</Inventory>");
            }

            return xml;
        }

        public void LoadFromXml(XElement xmlElement)
        {
            IdManager idManager = IdManager.GetIdManager();

            InventoryItems = new List<InventoryItem>();

            foreach (XElement inventoryItemsElement in xmlElement.Elements("InventoryItems"))
            {
                foreach (XElement inventoryItemElement in inventoryItemsElement.Elements("InventoryItem"))
                {
                    InventoryItem inventoryItem = new InventoryItem();

                    inventoryItem.LoadFromXml(inventoryItemElement);

                    InventoryItems.Add(inventoryItem);
                }
            }

            foreach (var locationsElement in xmlElement.Elements("Locations"))
            {
                foreach (var locationElement in locationsElement.Elements("Location"))
                {
                    Location location = new Location();

                    location.LoadFromXml(locationElement);

                    Locations.Add(location);

                    idManager.RegisterId(location, location.Id);
                }
            }

            MerryUpLocationsWithInventoryItems();
        }

        void MerryUpLocationsWithInventoryItems()
        {
            foreach (InventoryItem inventoryItem in InventoryItems)
            {
                int indexFound = Locations.BinarySearch(new Location {Id = inventoryItem.LocationId});

                if(indexFound > 0)
                {
                    inventoryItem.Location = Locations[indexFound];
                }
            }
        }

        public bool Contains(Location location, CatalogItem catalogItem)
        {
            foreach(InventoryItem inventoryItem in InventoryItems)
            {
                if(inventoryItem.Location.Equals(location) && inventoryItem.CatalogItem.Equals(catalogItem))
                {
                    return true;
                }
            }

            return false;
        }
    }
}