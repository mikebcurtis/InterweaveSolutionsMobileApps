using MvvmCross.iOS.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveSolutionsMobileApps.Core;
using MvvmCross.Core.ViewModels;
using UIKit;
using MvvmCross.iOS.Views;

namespace InterweaveSolutionsMobileApps.Core.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate appDelegate, UIWindow window) : base(appDelegate, window){}

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxIosViewsContainer CreateIosViewsContainer()
        {
            return new StoryboardContainer();
        }
    }
}
