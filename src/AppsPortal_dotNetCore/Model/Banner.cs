using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortalCore.Model
{
    public class Banner
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Context { get; set; }
        public byte[] Image { get; set; }
        public string Title { get; set; }

        public ICollection<Buttons> ButtonDetails { get; set; }
    }
}
