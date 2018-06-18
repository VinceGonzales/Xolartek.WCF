using System;

namespace Xolartek.Entities
{
    public interface ITraitImpact
    {
        int Id { get; set; }
        string Impact { get; set; }
        ITrait Trait { get; set; }
    }
}
