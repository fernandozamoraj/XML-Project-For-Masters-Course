using System;
using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public class CatalogItem: Entity, IXmlSerializable, IComparable
    {
       
        public string VendorAssignedProductId { get; set; }
        public Vendor Supplier { get; set; }
        public string Description { get; set; }
        public virtual decimal UnitCost{ get; set; }

        public string VendorId
        {
            get
            {
                   return _vendorId;
            }
        }

        string _vendorId;

        public CatalogItem()
        {
            VendorAssignedProductId = string.Empty;
            Supplier = new Vendor();
            Description = String.Empty;
            UnitCost = 0M;
        }

        public virtual List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;

            if(includeRootElement)
            {
                xml.Add(leftPadding + "<CatalogItem>");
                xml[0] = XMLHelper.AddAttribute(xml[0], "VendorId", IdManager.FixId(Supplier.GetPrefix(), Supplier.Id));
                xml[0] = XMLHelper.AddAttribute(xml[0], "Id", IdManager.FixId(GetPrefix(), base.Id));
                xml[0] = XMLHelper.AddAttribute(xml[0], "VendorAssignedProductId", VendorAssignedProductId);
            }

            xml.Add(innerPadding + XMLHelper.CreateElement("Description", Description));
            xml.Add(innerPadding + XMLHelper.CreateElement("UnitCost", UnitCost, ""));
            xml.Add(innerPadding + XMLHelper.CreateElement("Comments", Comments));
            if (includeRootElement)
            {
                xml.Add(leftPadding + "</CatalogItem>");
            }

            return xml;
        }



        public virtual void LoadFromXml(XElement xElement)
        {
            Id = xElement.GetAttributeValue<string>("Id");
            _vendorId = xElement.GetAttributeValue<string>("VendorId");
            VendorAssignedProductId = xElement.GetAttributeValue<string>("VendorAssignedProductId");
            Comments = xElement.GetElementValue<string>("Comments");
            Description = xElement.GetElementValue<string>("Description");
            UnitCost = xElement.GetElementValue<decimal>("UnitCost");
        }

        public override string ToString()
        {
            return Description;
        }

        public int CompareTo(object obj)
        {
            if(obj != null && obj is CatalogItem)
            {
                CatalogItem other = obj as CatalogItem;

                return Id.CompareTo(other.Id);
            }

            if(obj == null)
            {
                return 1;
            }

            return -1;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is CatalogItem)
            {
                CatalogItem other = obj as CatalogItem;

                return Id.CompareTo(other.Id) == 0;
            }

            return false;
        }
        
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string GetPrefix()
        {
            return PicassosInventorySystem.InventorySettings.Default.PrefixCatalog;
        }

        public void CopyFrom(CatalogItem source)
        {
            _vendorId = source._vendorId;
            Description = source.Description;
            Supplier = source.Supplier;
            UnitCost = source.UnitCost;
            VendorAssignedProductId = source.VendorAssignedProductId;
        }
    }
}
