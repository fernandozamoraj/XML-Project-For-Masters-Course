using System;
using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public class BoxedItem : CatalogItem, IXmlSerializable
    {
        public decimal BoxCost { get; set; }
        public int UnitsInBox { get; set; }

        public override decimal UnitCost
        {
            set
            {
                BoxCost = UnitCost*value;
            }
            get
            {
                if(UnitsInBox != 0)
                    return BoxCost/UnitsInBox;

                return 0;
            } 
        }

        public override List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();

            string innerPadding = leftPadding + "   ";

            if(includeRootElement)
            {
                xml.Add(leftPadding + "<BoxedItem>");
                xml[0] = XMLHelper.AddAttribute(xml[0], "VendorId", IdManager.FixId(Supplier.GetPrefix(), Supplier.Id));
                xml[0] = XMLHelper.AddAttribute(xml[0], "Id", IdManager.FixId(GetPrefix(), base.Id));
                xml[0] = XMLHelper.AddAttribute(xml[0], "VendorAssignedProductId", VendorAssignedProductId);
            }

            xml.AddRange(base.ProduceXml(leftPadding, false));

            xml.Add(innerPadding + XMLHelper.CreateElement("BoxCost", BoxCost, ""));
            xml.Add(innerPadding + XMLHelper.CreateElement("UnitsInBox", UnitsInBox, ""));

            if(includeRootElement)
            {
                xml.Add(leftPadding + "</BoxedItem>");
            }

            return xml;
        }

        public override void LoadFromXml(XElement xElement)
        {
            base.LoadFromXml(xElement);
            BoxCost = xElement.GetElementValue<decimal>("BoxCost");
            UnitsInBox = xElement.GetElementValue<int>("UnitsInBox");
        }

        public override bool Equals(object obj)
        {
            if (obj is BoxedItem)
            {
                return ToString().Equals(obj.ToString());
            }

            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} (Box of {1})", base.ToString(), this.UnitsInBox);
        }
    }
}