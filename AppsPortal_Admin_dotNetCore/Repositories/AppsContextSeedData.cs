using AppsPortal.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Admin.dotNetCore.Repositories
{
    public class AppsContextSeedData
    {
        private AppsContext _context;

        public AppsContextSeedData(AppsContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Apps.Any())
            {
                var modelLauncherApp = new Apps() {
                    Title = "Model Launcher",
                    SubTitle = "",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    Media = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    TeklaVersion = "18.0, 19.0, 20.0, 21.0, 21.1",
                    OS = "Windows 7, 8, 8.1, 10",
                    Download = "",
                    Active = true,
                    Order = 0,
                    ButtonDetails = new List<Buttons>()
                    { },
                    FeedBacks = new List<Feedback>()
                    { },
                    AppFeatures = new List<AppFeature>()
                    { }
                };

                _context.Apps.Add(modelLauncherApp);
                _context.Buttons.AddRange(modelLauncherApp.ButtonDetails);
                _context.Feedbacks.AddRange(modelLauncherApp.FeedBacks);
                _context.AppFeatures.AddRange(modelLauncherApp.AppFeatures);

                var packageToolApp = new Apps()
                {
                    Title = "Package Tool",
                    SubTitle = "",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    Media = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    TeklaVersion = "18.0, 19.0, 20.0, 21.0, 21.1",
                    OS = "Windows 7, 8, 8.1, 10",
                    Download = "",
                    Active = true,
                    Order = 1,
                    ButtonDetails = new List<Buttons>()
                    { },
                    FeedBacks = new List<Feedback>()
                    { },
                    AppFeatures = new List<AppFeature>()
                    { }


                };

                _context.Apps.Add(packageToolApp);
                _context.Buttons.AddRange(packageToolApp.ButtonDetails);
                _context.Feedbacks.AddRange(packageToolApp.FeedBacks);
                _context.AppFeatures.AddRange(packageToolApp.AppFeatures);

                var appsPortal = new Apps()
                {
                    Title = "AppsPortal",
                    SubTitle = "",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    Media = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    TeklaVersion = "",
                    OS = "Windows 7, 8, 8.1, 10",
                    Download = "",
                    Active = true,
                    Order = 2,
                    ButtonDetails = new List<Buttons>()
                    { },
                    FeedBacks = new List<Feedback>()
                    { },
                    AppFeatures = new List<AppFeature>()
                    { }

                };

                _context.Apps.Add(appsPortal);
                _context.Buttons.AddRange(appsPortal.ButtonDetails);
                _context.Feedbacks.AddRange(appsPortal.FeedBacks);
                _context.AppFeatures.AddRange(packageToolApp.AppFeatures);

                await _context.SaveChangesAsync();
            }

            if (!_context.Slides.Any())
            {
                var slide1 = new Slides()
                {
                    Title = "Slide 1",
                    Active = true,
                    Header = "Slide 1",
                    Content = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    Order = 0,
                    ButtonDetails = new List<Buttons>()
                    { }
                };

                _context.Slides.Add(slide1);
                _context.Buttons.AddRange(slide1.ButtonDetails);

                var slide2 = new Slides()
                {
                    Title = "Slide 2",
                    Active = true,
                    Header = "Slide 2",
                    Content = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    Order = 0,
                    ButtonDetails = new List<Buttons>()
                    { }
                };

                _context.Slides.Add(slide2);
                _context.Buttons.AddRange(slide2.ButtonDetails);

                var slide3 = new Slides()
                {
                    Title = "Slide 3",
                    Active = true,
                    Header = "Slide 3",
                    Content = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    Order = 0,
                    ButtonDetails = new List<Buttons>()
                    { }
                };

                _context.Slides.Add(slide3);
                _context.Buttons.AddRange(slide3.ButtonDetails);

                await _context.SaveChangesAsync();
            }
        }
    }
}
