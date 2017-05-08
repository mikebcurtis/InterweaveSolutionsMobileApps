using System;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using MvvmCross.Binding.ExtensionMethods;

namespace InterweaveSolutionsMobileApps.Core.iOS.Views
{
    public class MeetingsListTableViewSource : MvxTableViewSource
    {
        public MeetingsListTableViewSource(UITableView tableView) : base(tableView)
        {

        }

        public MeetingsListTableViewSource(IntPtr handle) : base(handle)
        {

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1; // we aren't using sections, so always return 1
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return ItemsSource.Count();
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = (MeetingsListCell)tableView.DequeueReusableCell(MeetingsListCell.Identifier);
            return cell;
        }
    }
}