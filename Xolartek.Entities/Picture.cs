using System;
using System.Runtime.Serialization;

namespace Xolartek.Entities
{
    [DataContract]
    public class Picture : IPicture
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Source { get; set; }
        [DataMember]
        public virtual string CSSClass { get; set; }
        [DataMember]
        public virtual string Alternate { get; set; }
    }
}
