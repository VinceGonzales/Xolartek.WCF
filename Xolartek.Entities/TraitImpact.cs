using System;
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
    }
}
