using System;
using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Model
{
    public class Location : Entity, IXmlSerializable, IComparable
    {
        public string Name { get; set; }
        public string Description { get; set; }
 
        public Location()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;

            if(includeRootElement)
            {
                xml.Add(leftPadding + "<Location>");
                xml[0] = XMLHelper.AddAttribute(xml[0], "Id", IdManager.FixId(GetPrefix(), Id));
            }

            xml.Add(innerPadding + XMLHelper.CreateElement("Name", Name));
            xml.Add(innerPadding + XMLHelper.CreateElement("Description", Description));

            if (includeRootElement)
            {
                xml.Add(leftPadding + "</Location>");
            }

            return xml;
        }

        public void LoadFromXml(XElement xElement)
        {
            Id = xElement.GetAttributeValue<string>("Id");
            Name = xElement.GetElementValue<string>("Name");
            Description = xElement.GetElementValue<string>("Description");
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }

        public int CompareTo(object obj)
        {
            if(obj is Location)
            {
                ToString().CompareTo(obj.ToString());
            }

            return -1;
        }

        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                return ToString().Equals(obj.ToString());
            }

            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string GetPrefix()
        {
            return PicassosInventorySystem.InventorySettings.Default.PrefixLocation;
        }
    }
}