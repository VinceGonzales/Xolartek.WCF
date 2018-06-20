using System;

namespace Xolartek.Entities
{
    public interface IWeaponTrap : ISchematic
    {
        decimal ReloadTime { get; set; }
    }
}