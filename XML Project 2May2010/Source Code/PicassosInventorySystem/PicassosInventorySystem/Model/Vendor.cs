using System;
using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Utility;
using PicassosInventorySystem.Extensions;

namespace PicassosInventorySystem.Model
{
    public class Vendor : Entity, IXmlSerializable
    {
        public string Name { get; set; }
        public string PointOfContact { get; set; }
        public string PhoneNumber { get; set; }
        public List<Address> Addresses { get; set; }

        public Vendor()
        {
            Addresses = new List<Address>();
            Name = string.Empty;
            PointOfContact = string.Empty;
            PhoneNumber = string.Empty;
        }

        public List<string> ProduceXml(string leftPadding, bool includeRootElement)
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding + Constants.XML_PADDING;
            if(includeRootElement)
            {
                xml.Add(leftPadding + "<Vendor>");
                xml[0] = XMLHelper.AddAttribute(xml[0], "Id", IdManager.FixId(GetPrefix(), base.Id));
            }

            xml.Add(innerPadding + XMLHelper.CreateElement("Name", Name));
            xml.Add(innerPadding + XMLHelper.CreateElement("PointOfContact", PointOfContact));
            xml.Add(innerPadding + XMLHelper.CreateElement("PhoneNumber", PhoneNumber));
            xml.Add(innerPadding + XMLHelper.CreateElement("Comments", Comments));
            xml.AddRange(Addresses.ProduceXml(innerPadding, "Addresses"));

            if(includeRootElement)
            {
                xml.Add(leftPadding + "</Vendor>");
            }

            return xml;
        }

        public void LoadFromXml(XElement xElement)
        {
            Id = xElement.GetAttributeValue<string>("Id");
            //throw new NotImplementedException();
            Name = xElement.GetElementValue<string>("Name");
            PointOfContact = xElement.GetElementValue<string>("PointOfContact");
            PhoneNumber = xElement.GetElementValue<string>("PhoneNumber");
            Comments = xElement.GetElementValue<string>("Comments");

            foreach (XElement addressesElement in xElement.Elements("Addresses"))
            {
                foreach (XElement addressElement in addressesElement.Elements("Address"))
                {
                    Address address = new Address();
   
                    address.LoadFromXml(addressElement);

                    Addresses.Add(address);
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string GetPrefix()
        {
            return PicassosInventorySystem.InventorySettings.Default.PrefixVendor;
        }
    }
}