using System;

namespace Xolartek.Entities
{
    public interface ITraitImpact
    {
        int Id { get; set; }
        string Impact { get; set; }
        int WeaponClass { get; set; }
        int TraitId { get; set; }
        ITrait Trait { get; set; }
    }
}
