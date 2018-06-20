using System.Runtime.Serialization;

namespace Xolartek.Entities
{
    [DataContract]
    public class TraitImpact : ITraitImpact
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Impact { get; set; }
        [DataMember]
        public virtual int WeaponClass { get; set; }
        [DataMember]
        public virtual int TraitId { get; set; }
        [DataMember]
        public virtual int SchematicId { get; set; }

        private ITrait _trait { get; set; }
        [DataMember]
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
        [DataMember]
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
