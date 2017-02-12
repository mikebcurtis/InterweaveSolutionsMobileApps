using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;

namespace InterweaveSolutionsMobileApps.Core.iOS
{
    public class StoryboardContainer : MvxIosViewsContainer
    {
        protected override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            return (IMvxIosView)UIStoryboard.FromName("Storyboard", null).InstantiateViewController(viewType.Name);
        }
    }
}