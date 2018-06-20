using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xolartek.Entities
{
    [DataContract]
    public class Trait : ITrait
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public ICollection<TraitImpact> TraitImpacts { get; set; }
    }
}
