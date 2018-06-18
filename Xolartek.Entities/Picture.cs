using System;

namespace Xolartek.Entities
{
    public class Picture : IPicture
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string CSSClass { get; set; }
        public string Alternate { get; set; }
    }
}
