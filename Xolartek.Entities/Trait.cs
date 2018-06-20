using System.Collections.Generic;

namespace Xolartek.Entities
{
    public class Trait : ITrait
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }

        public virtual ICollection<TraitImpact> TraitImpacts { get; set; }
    }
}
