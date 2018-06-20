using System;

namespace Xolartek.Entities
{
    public class Picture : IPicture
    {
        public virtual int Id { get; set; }
        public virtual string Source { get; set; }
        public virtual string CSSClass { get; set; }
        public virtual string Alternate { get; set; }
    }
}
