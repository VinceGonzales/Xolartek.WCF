﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xolartek.Entities
{
    public class TraitImpact : ITraitImpact
    {
        public int Id { get; set; }
        public string Impact { get; set; }
        public int WeaponClass { get; set; }
        public int TraitId { get; set; }
        public int SchematicId { get; set; }

        private ITrait _trait { get; set; }
        public Trait Trait
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
        public Schematic Schematic
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
