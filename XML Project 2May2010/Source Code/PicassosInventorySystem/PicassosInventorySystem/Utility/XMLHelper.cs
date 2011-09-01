namespace PicassosInventorySystem.Utility
{
    public class XMLHelper
    {
        public static string AddAttribute(string fullElment, string attribute, string value)
        {
            //Try closed element first
            int indexOfFirstClosingBracket = fullElment.IndexOf("/>");

            if(indexOfFirstClosingBracket < 0)
            {
                indexOfFirstClosingBracket = fullElment.IndexOf(">");
            }

            string newAttributeValue = string.Format(" {0}=\"{1}\" ", attribute, value);
            string newElementValue = fullElment.Insert(indexOfFirstClosingBracket, newAttributeValue);

            return newElementValue;
        }

        public static string CreateElement(string elementName, string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                return string.Format("<{0}/>", elementName);
            }

            return string.Format("<{0}>{1}</{2}>", elementName, value, elementName);
        }

        public static string CreateElement(string elementName, decimal value, string format)
        {
            if (format != string.Empty)
            {
                return CreateElement(elementName, value.ToString(format));
            }

            return CreateElement(elementName, value.ToString());
        }

        public static string CreateElement(string elementName, int value, string format)
        {
            if (format != string.Empty)
            {
                return CreateElement(elementName, value.ToString(format));
            }

            return CreateElement(elementName, value.ToString());
        }

    }
}
