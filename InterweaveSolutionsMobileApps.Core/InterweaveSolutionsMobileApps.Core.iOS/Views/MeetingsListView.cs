using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using MvvmCross.iOS.Views;
using InterweaveSolutionsMobileApps.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using InterweaveSolutionsMobileApps.Core.iOS.Views;

namespace InterweaveSolutionsMobileApps.Core.iOS
{
    public partial class MeetingsListView : BaseView
    {
        protected MeetingsListViewModel MeetingsListViewModel => ViewModel as MeetingsListViewModel;
        private MeetingsListTableViewSource _meetingsListTableViewSource;

        public MeetingsListView(IntPtr handle) : base(handle)
        {
        }

        protected override void CreateBindings()
        {
            var set = this.CreateBindingSet<MeetingsListView, MeetingsListViewModel>();
            set.Bind(_meetingsListTableViewSource).To(vm => vm.Meetings);
            // TODO set a binding here for what to do when a specific meeting is selected
            set.Apply();
        }

        public override void ViewDidLoad()
        {
            _meetingsListTableViewSource = new MeetingsListTableViewSource(meetingsListTableView);

            base.ViewDidLoad();

            meetingsListTableView.Source = _meetingsListTableViewSource;
            meetingsListTableView.ReloadData();
        }
    }
}
