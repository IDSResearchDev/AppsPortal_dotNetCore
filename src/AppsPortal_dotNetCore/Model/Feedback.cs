using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortalCore.Model
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Link { get; set; }
        public string Email { get; set; }

    }
}
