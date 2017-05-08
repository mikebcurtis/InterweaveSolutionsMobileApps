using Foundation;
using InterweaveSolutionsMobileApps.Core.Models;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using System;
using UIKit;

namespace InterweaveSolutionsMobileApps.Core.iOS
{
    partial class MeetingsListCell : MvxTableViewCell
    {
        internal static readonly NSString Identifier = new NSString("MeetingsListCell");

        public MeetingsListCell(IntPtr handle) : base(handle)
        {

        }

        private void CreateBindings()
        {
            var set = this.CreateBindingSet<MeetingsListCell, Meeting>();
            
            set.Bind(meetingNameLabel).To(vm => vm.Name);

            set.Apply();
        }
    }
}