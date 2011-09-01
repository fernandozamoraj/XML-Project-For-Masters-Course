using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public class InventoryItem : Entity, IXmlSerializable
    {
        string _locationId;
        string _catalogItemId;

        public CatalogItem CatalogItem { get; set; }
        public Location Location { get; set; }
        public string LocationId
        {
            get
            {
                if(!Location.IsNull())
                {
                    return Location.Id;
                }

                return _locationId;
            }
            set
            {
                _locationId = value;
            }
        }

        public string CatalogItemId
        {
            get
            {
                if(!CatalogItem.IsNull())
                {
                    return CatalogItem.Id;
                }

                return _catalogItemId;        
            }
            set
            {
                _catalogItemId = value;
            }
        }

        public int QtyOnHand { get; set; }
        public int ReOrderPoint { get; set; }
        public int ReOrderQuantity { get; set; }

        public InventoryItem()
        {
            CatalogItem = new CatalogItem();
            Location = new Location();
            QtyOnHand = 0;
            ReOrderPoint = 0;
            ReOrderQuantity = 0;
        }

        public List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;
            if (includeRootElement)
            {
                xml.Add(leftPadding + "<InventoryItem>");
                xml[0] = XMLHelper.AddAttribute(xml[0], "Id", IdManager.FixId(GetPrefix(), Id));
                xml[0] = XMLHelper.AddAttribute(xml[0], "LocationId", IdManager.FixId(Location.GetPrefix(), Location.Id));
                xml[0] = XMLHelper.AddAttribute(xml[0], "CatalogItemId", IdManager.FixId(CatalogItem.GetPrefix(), CatalogItem.Id));
            }

            xml.Add(innerPadding + XMLHelper.CreateElement("QtyOnHand", QtyOnHand, ""));
            xml.Add(innerPadding + XMLHelper.CreateElement("ReOrderPoint", ReOrderPoint, ""));
            xml.Add(innerPadding + XMLHelper.CreateElement("ReOrderQuantity", ReOrderQuantity, ""));
            xml.Add(innerPadding + XMLHelper.CreateElement("Comments", Comments));

            if (includeRootElement)
            {
                xml.Add(leftPadding + "</InventoryItem>");
            }

            return xml;

        }

        public void LoadFromXml(XElement xElement)
        {
            Id = xElement.GetAttributeValue<string>("Id");

            LocationId = xElement.GetAttributeValue<string>("LocationId");
            CatalogItemId = xElement.GetAttributeValue<string>("CatalogItemId");
            Comments = xElement.GetElementValue<string>("Comments");

            QtyOnHand = xElement.GetElementValue<int>("QtyOnHand");
            ReOrderPoint = xElement.GetElementValue<int>("ReOrderPoint");
            ReOrderQuantity = xElement.GetElementValue<int>("ReOrderQuantity");
        }

        public override string ToString()
        {
            return string.Format("{0} at {1}", CatalogItem.Description, Location.Name);
        }

        public override string GetPrefix()
        {
            return PicassosInventorySystem.InventorySettings.Default.PrefixInventory;
        }
    }
}