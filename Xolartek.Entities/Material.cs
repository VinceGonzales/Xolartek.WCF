using System;

namespace Xolartek.Entities
{
    public class Material : IMaterial
    {
        public int Id { get; set; }
        public string Description { get; set; }
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
    }
}
