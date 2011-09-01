using System;
using System.Collections.Generic;
using System.Xml.Linq;
using PicassosInventorySystem.Model;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Extensions
{
    public static class MyExtensions
    {
     
        /// <summary>
        /// IsValidXmlChar mostly is aimed to keep any characters that
        /// would keep an XML parser from properly parsing out XML such as
        /// <> but there are also others such as & and '
        /// To avoid any other unforseen drama the valid characters are limited
        /// to alphanumerics and a few symbols
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsValidXmlChar(this char c)
        {
            if(char.IsLetterOrDigit(c))
            {
                return true;
            }

            foreach(char validCharacter in Constants.VALID_CHARS_FOR_XML_DATA)
            {
                if(c == validCharacter)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidPicassoXmlString(this string myString)
        {
            foreach (char character in myString)
            {
                if (!character.IsValidXmlChar())
                {
                    return false;
                }
            }

            return true;
        }

        public static void LoadObjectFromXml<T>(this XElement rootElement, T target, string elementName) where T : IXmlSerializable
        {
            foreach (XElement xElement in rootElement.Elements(elementName))
            {
                target.LoadFromXml(xElement);
            }
        }

        public static T GetElementValue<T>(this XElement rootElement, string elementName)
        {
            T returnValue = default(T);

            foreach (XElement xElement in rootElement.Elements(elementName))
            {
                returnValue = (T)(SafeCast(typeof(T), xElement.Value));
            }

            return returnValue;
        }

        private static object SafeCast(Type t, string value)
        {
            if(t == typeof(int))
            {
                return Convert.ToInt32(value);
            }
            if(t == typeof(decimal))
            {
                return Convert.ToDecimal(value);
            }
            if(t == typeof(long))
            {
                return Convert.ToInt64(value);
            }
            if (t == typeof(uint))
            {
                return Convert.ToUInt32(value);
            }
            if (t == typeof(ulong))
            {
                return Convert.ToUInt64(value);
            }

            return value;
        }


        public static T GetAttributeValue<T>(this XElement rootElement, string attributeName)
        {
            T returnValue = default(T);

            foreach(XAttribute xAttribute in rootElement.Attributes(attributeName))
            {
                if(xAttribute != null)
                {
                    returnValue = (T)(SafeCast(typeof(T), xAttribute.Value));
                }
            }

            return returnValue;
        }

        public static List<string> ProduceXml<T>(this List<T> serializableItems, string leftPadding, string elementName) where T : IXmlSerializable
        {
            List<string> xml = new List<string>();
            string innerPadding = leftPadding;

            if(!string.IsNullOrEmpty(elementName))
            {
                xml.Add(string.Format("{0}<{1}>", leftPadding, elementName));
                innerPadding = leftPadding + Constants.XML_PADDING;
            }

            foreach(IXmlSerializable serializableItem in serializableItems)
            {
                xml.AddRange(serializableItem.ProduceXml(innerPadding, true));
            }

            if (!string.IsNullOrEmpty(elementName))
            {
                xml.Add(string.Format("{0}</{1}>", leftPadding, elementName));
            }

            return xml;
        }
    }
}
