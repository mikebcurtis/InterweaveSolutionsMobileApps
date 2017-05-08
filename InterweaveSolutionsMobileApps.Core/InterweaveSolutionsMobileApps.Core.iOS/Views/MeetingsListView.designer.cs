// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace InterweaveSolutionsMobileApps.Core.iOS
{
    [Register ("MeetingsListView")]
    partial class MeetingsListView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView meetingsListTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (meetingsListTableView != null) {
                meetingsListTableView.Dispose ();
                meetingsListTableView = null;
            }
        }
    }
}