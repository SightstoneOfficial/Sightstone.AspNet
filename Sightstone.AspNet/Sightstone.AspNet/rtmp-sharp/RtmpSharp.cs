using System.ComponentModel;

namespace RtmpSharp
{
    public class TypeSerializer
    {
        public void RegisterTypeConverters()
        {
            TypeDescriptor.AddAttributes(typeof(string), new TypeConverterAttribute(typeof(RtmpSharp.IO.TypeConverters.StringConverter)));
        }
    }
}
