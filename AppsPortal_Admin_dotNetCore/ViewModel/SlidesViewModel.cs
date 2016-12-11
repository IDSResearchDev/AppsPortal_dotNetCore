using AppsPortal.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Admin.dotNetCore.ViewModel
{
    public class SlidesViewModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }

        public IEnumerable<Buttons> ButtonDetails { get; set; }
    }
}
