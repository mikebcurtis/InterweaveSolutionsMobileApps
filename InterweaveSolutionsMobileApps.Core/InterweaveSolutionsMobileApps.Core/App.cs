using MvvmCross.Core.ViewModels;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            // TODO need to register classes with the IoC layer

            RegisterAppStart(new AppStart());
        }
    }
}
