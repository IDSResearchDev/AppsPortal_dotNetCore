using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal_dotNetCore.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }

        public ICollection<ProductRelease> ReleaseData { get; set; }
    }
}
