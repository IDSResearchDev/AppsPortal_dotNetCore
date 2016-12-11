using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Entities.Model
{
    public class Slides
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }

        public ICollection<Buttons> ButtonDetails { get; set; }
    }
}
