using System;
using System.Collections.Generic;
using System.Text;

namespace Xolartek.Entities
{
    public class TraitImpact : ITraitImpact
    {
        public virtual int Id { get; set; }
        public virtual string Impact { get; set; }
        public virtual int WeaponClass { get; set; }
        public virtual int TraitId { get; set; }
        public virtual int SchematicId { get; set; }

        private ITrait _trait { get; set; }
        public virtual Trait Trait
        {
            get
            {
                return (Trait)_trait;
            }
            set
            {
                _trait = (Trait)value;
            }
        }
        ITrait ITraitImpact.Trait
        {
            get
            {
                return _trait;
            }
            set
            {
                _trait = value;
            }
        }

        private ISchematic _schematic;
        public virtual Schematic Schematic
        {
            get
            {
                return (Schematic)_schematic;
            }
            set
            {
                _schematic = (Schematic)value;
            }
        }
        ISchematic ITraitImpact.Schematic
        {
            get
            {
                return _schematic;
            }
            set
            {
                _schematic = value;
            }
        }
    }
}
