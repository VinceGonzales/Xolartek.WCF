using System;
using System.Runtime.Serialization;

namespace Xolartek.Entities
{
    [DataContract]
    public class Picture : IPicture
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public string CSSClass { get; set; }
        [DataMember]
        public string Alternate { get; set; }
    }
}
