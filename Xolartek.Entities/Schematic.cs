using System;
using System.Collections.Generic;
using System.Linq;

namespace Xolartek.Entities
{
    public class Schematic : ISchematic, IWeaponMelee, IWeaponRange, IWeaponTrap
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int WeaponClass { get; set; }
        public virtual int Durability { get; set; }
        public virtual int Level { get; set; }
        public virtual int Stars { get; set; }
        public virtual int Damage { get; set; }
        public virtual decimal CritChance { get; set; }
        public virtual decimal CritDamage { get; set; }
        public virtual decimal AttackRate { get; set; }
        public virtual decimal DurabilityPerUse { get; set; }
        public virtual int Impact { get; set; }
        public virtual decimal ReloadTime { get; set; }
        public virtual int MagazineSize { get; set; }
        public virtual int Range { get; set; }
        public virtual int AmmoCost { get; set; }

        private ICollection<ITraitImpact> _traits;
        public virtual ICollection<TraitImpact> Traits
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
        public virtual ICollection<MaterialCost> Materials
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

        public virtual int RarityId { get; set; }
        private ITrait _rarity { get; set; }
        public virtual Trait Rarity
        {
            get
            {
                return (Trait)_rarity;
            }
            set
            {
                _rarity = (Trait)value;
            }
        }
        ITrait ISchematic.Rarity
        {
            get
            {
                return _rarity;
            }
            set
            {
                _rarity = value;
            }
        }

        public virtual int? PictureId { get; set; }
        private IPicture _picture;
        public virtual Picture Picture
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

        public virtual int? WeaponEditionId { get; set; }
        private ITrait _weaponEdition;
        public virtual Trait WeaponEdition
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

        public virtual int? WeaponTypeId { get; set; }
        private ITrait _weaponType;
        public virtual Trait WeaponType
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
