using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal_dotNetCore.Model
{
    public class ProductContextSeedData
    {
        private ProductContext _context;

        public ProductContextSeedData(ProductContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Products.Any())
            {
                var modelLauncherApp = new Product() {
                    Name = "Model Launcher",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    VideoUrl = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    ReleaseData = new List<ProductRelease>()
                    {
                        new ProductRelease() { Details= "Initial Release", Date = new DateTime(2015,7,1), AppVersion = "1.3.1", Order =1 },
                        new ProductRelease() { Details = "Bug Fixes 1", Date = new DateTime(2015, 7, 15), AppVersion = "1.3.2", Order = 2  },
                        new ProductRelease() { Details = "Bug Fixes 2", Date = new DateTime(2015, 8, 15), AppVersion = "1.3.3", Order = 3  },
                        new ProductRelease() { Details = "Bug Fixes 3", Date = new DateTime(2015, 9, 15), AppVersion = "1.3.4", Order = 4  },
                        new ProductRelease() { Details = "Bug Fixes 4", Date = new DateTime(2015, 10, 15), AppVersion = "1.3.5", Order = 5  },
                        new ProductRelease() { Details = "Bug Fixes 4", Date = new DateTime(2015, 10, 15), AppVersion = "1.3.6", Order = 6  }
                    }

                };

                _context.Products.Add(modelLauncherApp);
                _context.ProductReleases.AddRange(modelLauncherApp.ReleaseData);

                var packageToolApp = new Product()
                {
                    Name = "Package Tool",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    VideoUrl = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    ReleaseData = new List<ProductRelease>()
                    {
                        new ProductRelease() { Details = "Initial Release", Date = new DateTime(2015, 8, 1), AppVersion = "1.0.4", Order = 1  },
                        new ProductRelease() { Details = "Bug Fixes 1", Date = new DateTime(2015, 9, 15), AppVersion = "1.0.5", Order = 2  }
                    }

                };

                _context.Products.Add(packageToolApp);
                _context.ProductReleases.AddRange(packageToolApp.ReleaseData);

                var appsPortal = new Product()
                {
                    Name = "AppsPortal",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    VideoUrl = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    ReleaseData = new List<ProductRelease>()
                    {
                        new ProductRelease() { Details = "Initial Release", Date = new DateTime(2015, 8, 1), AppVersion = "1.0.0", Order = 1  },
                        new ProductRelease() { Details = "Bug Fixes 1", Date = new DateTime(2015, 9, 15), AppVersion = "1.0.1", Order = 2  },
                        new ProductRelease() { Details = "Bug Fixes 2", Date = new DateTime(2015, 10, 15), AppVersion = "1.0.2", Order = 3  },
                        new ProductRelease() { Details = "Bug Fixes 3", Date = new DateTime(2015, 11, 15), AppVersion = "1.0.3", Order = 4  },
                        new ProductRelease() { Details = "Bug Fixes 4", Date = new DateTime(2015, 12, 15), AppVersion = "1.0.4", Order = 5  }
                    }

                };

                _context.Products.Add(appsPortal);
                _context.ProductReleases.AddRange(appsPortal.ReleaseData);

                await _context.SaveChangesAsync();
            }
        }
    }
}
