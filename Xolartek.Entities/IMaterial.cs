using System;

namespace Xolartek.Entities
{
    public interface IMaterial
    {
        int Id { get; set; }
        string Description { get; set; }
        int? PictureId { get; set; }
        IPicture Picture { get; set; }
    }
}
