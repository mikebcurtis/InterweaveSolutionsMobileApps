using InterweaveSolutionsMobileApps.Core.iOS.Utility;
using InterweaveSolutionsMobileApps.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace InterweaveSolutionsMobileApps.Core.iOS.Views
{
    public class MainViewController : MvxTabBarViewController<MainViewModel>
    {
        private nint _tabsCreatedSoFar;

        protected MainViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateTabs();
        }

        private void CreateTabs()
        {
            var viewControllers = new UIViewController[]
            {
                CreateTab("Grupos y Estudiantes", "user_icon", Mvx.Resolve<IGroupsListViewModel>()),
                CreateTab("Reuniones", "user_icon", Mvx.Resolve<IMeetingsListViewModel>()),
                CreateTab("Certificados", "user_icon", Mvx.Resolve<ICertificateListViewModel>())
            };

            ViewControllers = viewControllers;

            SelectedViewController = ViewControllers[0];
            Title = SelectedViewController.Title;

            NavigationItem.Title = SelectedViewController.Title;

            ViewControllerSelected += (o, e) =>
            {
                NavigationItem.Title = TabBar.SelectedItem.Title;
            };
        }

        private UIViewController CreateTab(string title, string imgName, IMvxViewModel viewModel)
        {
            var viewController = this.CreateViewControllerFor(viewModel) as UIViewController;
            viewModel.Start();

            UpdateTabBar(viewController, title, imgName);

            return viewController;
        }

        private void UpdateTabBar(UIViewController viewController, string title, string imgName)
        {
            viewController.Title = title;
            viewController.TabBarItem = new UITabBarItem(
                title,
                UIImage.FromBundle(imgName + ".png").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal),
                _tabsCreatedSoFar
            )
            {
                SelectedImage = UIImage.FromBundle(imgName + "_active.png")
                    .ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal)
            };

            var font = UIFont.FromName("Helvetica", 10);

            viewController.TabBarItem.SetTitleTextAttributes(
                new UITextAttributes { TextColor = InterweaveSolutionsColors.DarkTextColor, Font = font },
                UIControlState.Normal);

            viewController.TabBarItem.SetTitleTextAttributes(
                new UITextAttributes { TextColor = InterweaveSolutionsColors.AccentTextColor, Font = font },
                UIControlState.Selected);

            _tabsCreatedSoFar++;
        }
    }
}