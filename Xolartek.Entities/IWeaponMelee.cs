using System;

namespace Xolartek.Entities
{
    public interface IWeaponMelee : ISchematic
    {
        int? WeaponEditionId { get; set; }
        ITrait WeaponEdition { get; set; }
        int? WeaponTypeId { get; set; }
        ITrait WeaponType { get; set; }
    }
}
