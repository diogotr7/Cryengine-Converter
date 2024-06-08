using System;
using System.Xml;
using System.Xml.Serialization;

namespace CgfConverter.Renderers.Collada.Collada.Collada_Core.Lighting;

[Serializable]
[XmlType(AnonymousType = true)]
public partial class ColladaDirectional
{
    [XmlElement(ElementName = "color")]
    public ColladaColor Color;

}

