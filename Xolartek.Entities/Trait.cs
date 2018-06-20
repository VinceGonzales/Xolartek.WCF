using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xolartek.Entities
{
    [DataContract]
    public class Trait : ITrait
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Description { get; set; }
        [DataMember]
        public virtual ICollection<TraitImpact> TraitImpacts { get; set; }
    }
}
