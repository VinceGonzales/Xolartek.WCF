using System;

namespace Xolartek.Entities
{
    public interface IMaterialCost
    {
        int Id { get; set; }
        int Cost { get; set; }
        int WeaponClass { get; set; }
        int MaterialId { get; set; }
        int SchematicId { get; set; }
        IMaterial Material { get; set; }
        ISchematic Schematic { get; set; }
    }
}
