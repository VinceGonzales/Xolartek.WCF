using System;
using System.Collections.Generic;
using System.Text;

namespace Xolartek.Entities
{
    public class MaterialCost : IMaterialCost
    {
        public virtual int Id { get; set; }
        public virtual int Cost { get; set; }
        public virtual int WeaponClass { get; set; }
        public virtual int MaterialId { get; set; }
        public virtual int SchematicId { get; set; }

        private IMaterial _material;
        public virtual Material Material
        {
            get
            {
                return (Material)_material;
            }
            set
            {
                _material = (Material)value;
            }
        }
        IMaterial IMaterialCost.Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
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
        ISchematic IMaterialCost.Schematic
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
