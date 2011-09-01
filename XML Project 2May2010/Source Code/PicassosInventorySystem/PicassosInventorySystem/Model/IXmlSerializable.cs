using System.Collections.Generic;
using System.Xml.Linq;

namespace PicassosInventorySystem.Model
{
    public interface IXmlSerializable
    {
        List<string> ProduceXml(string leftPadding, bool includeRootElement);
        void LoadFromXml(XElement xmlDocument);
    }
}
