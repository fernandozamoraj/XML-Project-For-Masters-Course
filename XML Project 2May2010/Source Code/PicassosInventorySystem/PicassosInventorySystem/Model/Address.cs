using System;
using System.Collections.Generic;
using System.Xml;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Utility;
using System.Xml.Linq;

namespace PicassosInventorySystem.Model
{
    public class Address : IXmlSerializable
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public List<string> ProduceXml(string leftPadding, bool includeRoot)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;
            if(includeRoot)
            {
                xml.Add(leftPadding + "<Address>");
            }

            xml.Add(innerPadding + XMLHelper.CreateElement("Street", Street));
            xml.Add(innerPadding + XMLHelper.CreateElement("City", City));
            xml.Add(innerPadding + XMLHelper.CreateElement("State", State));
            xml.Add(innerPadding + XMLHelper.CreateElement("Zip", Zip));
            
            if(includeRoot)
            {
                xml.Add(leftPadding + "</Address>");
            }

            return xml;
        }

        public void LoadFromXml(XElement xmlElement)
        {
            Street = xmlElement.GetElementValue<string>("Street");
            City = xmlElement.GetElementValue<string>("City");
            State = xmlElement.GetElementValue<string>("State");
            Zip = xmlElement.GetElementValue<string>("Zip");
        }
    }
}