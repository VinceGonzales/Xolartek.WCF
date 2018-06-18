using System;

namespace Xolartek.Entities
{
    public interface IMaterialCost
    {
        int Id { get; set; }
        int Cost { get; set; }
        IMaterial Material { get; set; }
    }
}
