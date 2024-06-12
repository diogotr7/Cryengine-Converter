using System;
using System.Xml.Serialization;

namespace CgfConverter.Renderers.Collada.Collada.Enums
{
    [Serializable]
    [XmlType(Namespace = "http://www.collada.org/2005/11/COLLADASchema")]
    public enum ColladaFXOpaqueChannel
    {
        A_ONE,
        RGB_ZERO,
        A_ZERO,
        RGB_ONE
    }
}
