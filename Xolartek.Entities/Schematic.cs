using System;
using System.Collections.Generic;
using System.Linq;

namespace Xolartek.Entities
{
    public class Schematic : ISchematic, IWeaponMelee, IWeaponRange, IWeaponTrap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WeaponClass { get; set; }
        public int Durability { get; set; }
        public ITrait Rarity { get; set; }
        public int Level { get; set; }
        public int Stars { get; set; }
        public int Damage { get; set; }
        public decimal CritChance { get; set; }
        public decimal CritDamage { get; set; }
        public decimal AttackRate { get; set; }
        public decimal DurabilityPerUse { get; set; }
        public int Impact { get; set; }
        public decimal ReloadTime { get; set; }
        public int MagazineSize { get; set; }
        public int Range { get; set; }
        public int AmmoCost { get; set; }

        private ICollection<ITraitImpact> _traits;
        public ICollection<TraitImpact> Traits
        {
            get
            {
                if(_traits == null)
                {
                    return null;
                }
                return _traits.Select(t => t as TraitImpact).ToList();
            }
            set
            {
                _traits = value.Select(t => t as ITraitImpact).ToList();
            }
        }
        ICollection<ITraitImpact> ISchematic.Traits
        {
            get
            {
                return _traits;
            }
            set
            {
                _traits = value;
            }
        }

        private ICollection<IMaterialCost> _materials;
        public ICollection<MaterialCost> Materials
        {
            get
            {
                if(_materials == null)
                {
                    return null;
                }
                return _materials.Select(m => (MaterialCost)m).ToList();
            }
            set
            {
                _materials = value.Select(m => m as IMaterialCost).ToList();
            }
        }
        ICollection<IMaterialCost> ISchematic.Materials
        {
            get
            {
                return _materials;
            }
            set
            {
                _materials = value;
            }
        }

        public int? PictureId { get; set; }
        private IPicture _picture;
        public Picture Picture
        {
            get
            {
                return (Picture)_picture;
            }
            set
            {
                _picture = (Picture)value;
            }
        }
        IPicture ISchematic.Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
            }
        }

        public int? WeaponEditionId { get; set; }
        private ITrait _weaponEdition;
        public Trait WeaponEdition
        {
            get
            {
                return (Trait)_weaponEdition;
            }
            set
            {
                _weaponEdition = (Trait)value;
            }
        }
        ITrait ISchematic.WeaponEdition
        {
            get
            {
                return _weaponEdition;
            }
            set
            {
                _weaponEdition = value;
            }
        }

        public int? WeaponTypeId { get; set; }
        private ITrait _weaponType;
        public Trait WeaponType
        {
            get
            {
                return (Trait)_weaponType;
            }
            set
            {
                _weaponType = (Trait)value;
            }
        }
        ITrait ISchematic.WeaponType
        {
            get
            {
                return _weaponType;
            }
            set
            {
                _weaponType = value;
            }
        }
    }
}
