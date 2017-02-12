using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using MvvmCross.iOS.Views;
using InterweaveSolutionsMobileApps.Core.ViewModels;

namespace InterweaveSolutionsMobileApps.Core.iOS.Views
{
    public class MeetingsListView : BaseView
    {
        protected MeetingsListViewModel MeetingsListViewModel => ViewModel as MeetingsListViewModel;

        public MeetingsListView(IntPtr handle) : base(handle)
        {
        }
    }
}
