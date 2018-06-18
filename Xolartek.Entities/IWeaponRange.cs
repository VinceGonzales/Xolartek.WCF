using System;

namespace Xolartek.Entities
{
    public interface IWeaponRange : ISchematic
    {
        int MagazineSize { get; set; }
        int Range { get; set; }
        decimal ReloadTime { get; set; }
        int AmmoCost { get; set; }
        int? WeaponEditionId { get; set; }
        ITrait WeaponEdition { get; set; }
        int? WeaponTypeId { get; set; }
        ITrait WeaponType { get; set; }
    }
}
