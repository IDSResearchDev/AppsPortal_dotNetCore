using System;

namespace AppsPortalCore.Model
{
    public class ProductRelease
    {
        public int Id { get; set; }
        public string AppVersion { get; set; }

        public DateTime Date { get; set; }
        public string Details { get; set; }
        public int Order { get; set; }
    }
}
