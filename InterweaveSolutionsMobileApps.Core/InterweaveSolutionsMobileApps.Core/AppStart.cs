using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public async void Start(object hint = null)
        {
            //TODO navigate to the default viewmodel with ShowViewModel<GroupsViewModel>();
        }
    }
}
