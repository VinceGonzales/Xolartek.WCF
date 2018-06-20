using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xolartek.Entities
{
    [DataContract]
    public class Material : IMaterial
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Description { get; set; }
        [DataMember]
        public virtual int? PictureId { get; set; }

        private IPicture _picture;
        [DataMember]
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
        IPicture IMaterial.Picture
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

        [DataMember]
        public virtual ICollection<MaterialCost> MaterialCosts { get; set; }
    }
}
