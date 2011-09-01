using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    /// <summary>
    /// Volume items is those items that come in a certain volumen
    /// like gallons, or by the foot or square yard etc
    /// they are not necessarily sold individually but they
    /// also not sold in boxes
    /// </summary>
    public class VolumeItem : CatalogItem
    {
        public decimal MininumVolume { get; set; }
        public string UnitOfMeasure { get; set; }
        
        public VolumeItem()
        {
            MininumVolume = 0;
            UnitOfMeasure = string.Empty;
        }

        public override List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();

            string innerPadding = leftPadding + Constants.XML_PADDING;

            if (includeRootElement)
            {
                xml.Add(leftPadding + "<VolumeItem>");
                xml[0] = XMLHelper.AddAttribute(xml[0], "VendorId", Supplier.Id);
                xml[0] = XMLHelper.AddAttribute(xml[0], "Id", base.Id);
                xml[0] = XMLHelper.AddAttribute(xml[0], "VendorAssignedProductId", VendorAssignedProductId);

            }

            xml.AddRange(base.ProduceXml(leftPadding, false));

            xml.Add(innerPadding + XMLHelper.CreateElement("MinimumVolume", MininumVolume, ""));
            xml.Add(innerPadding + XMLHelper.CreateElement("UnitOfMeasure", UnitOfMeasure));
       
            if(includeRootElement)
            {
                xml.Add(leftPadding + "</VolumeItem>");
            }

            return xml;
        }

        public override void LoadFromXml(XElement xElement)
        {
            base.LoadFromXml(xElement);

            MininumVolume = xElement.GetElementValue<decimal>("MinimumVolume");
            UnitOfMeasure = xElement.GetElementValue<string>("UnitOfMeasure");
        }

        public override bool Equals(object obj)
        {
            if (obj is VolumeItem)
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
            return string.Format("{0} (Unit of Measure:{1})", base.ToString(), this.UnitOfMeasure);
        }
    }
}