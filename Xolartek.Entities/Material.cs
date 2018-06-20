using System.Collections.Generic;

namespace Xolartek.Entities
{
    public class Material : IMaterial
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
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

        public virtual ICollection<MaterialCost> MaterialCosts { get; set; }
    }
}
