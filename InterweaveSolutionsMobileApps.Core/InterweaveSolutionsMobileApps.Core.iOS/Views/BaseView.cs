using MvvmCross.iOS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core.iOS.Views
{
    public class BaseView : MvxViewController
    {
        public BaseView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateBindings();
        }

        protected virtual void CreateBindings()
        { }
    }
}
