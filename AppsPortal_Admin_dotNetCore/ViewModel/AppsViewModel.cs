using AppsPortal.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Admin.dotNetCore.ViewModel
{
    public class AppsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }
        public byte[] Icon { get; set; }
        public string TeklaVersion { get; set; }
        public string OS { get; set; }
        public string Download { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }

        public IEnumerable<Buttons> ButtonDetails { get; set; }
        public IEnumerable<Feedback> FeedBacks { get; set; }
        public IEnumerable<AppFeature> AppFeatures { get; set; }
    }
}
