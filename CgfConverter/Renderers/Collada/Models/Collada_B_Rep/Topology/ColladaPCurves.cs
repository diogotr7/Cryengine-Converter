using System;
using System.Xml;
using System.Xml.Serialization;
using CgfConverter.Collada;
using CgfConverter.Renderers.Collada.Collada.Collada_Core.Data_Flow;
using CgfConverter.Renderers.Collada.Collada.Collada_Core.Extensibility;

namespace CgfConverter.Renderers.Collada.Collada.Collada_B_Rep.Topology;

[Serializable]
[XmlType(AnonymousType = true)]
public partial class ColladaPCurves
{
    [XmlAttribute("count")]
    public int Count;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("id")]
    public string ID;

    [XmlElement(ElementName = "vcount")]
    public ColladaIntArrayString VCount;

    [XmlElement(ElementName = "p")]
    public ColladaIntArrayString P;

    [XmlElement(ElementName = "input")]
    public ColladaInputShared[] Input;

    [XmlElement(ElementName = "extra")]
    public ColladaExtra[] Extra;

}

