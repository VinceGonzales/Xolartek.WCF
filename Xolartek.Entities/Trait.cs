using System.Collections.Generic;

namespace Xolartek.Entities
{
    public class Trait : ITrait
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<TraitImpact> TraitImpacts { get; set; }
    }
}
