using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InterweaveMobile
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new TabbedPage();

            ContentPage groupsPage = new GroupsPage()
            {
                Title = "Groups"
            };

            ContentPage meetingsPage = new MeetingsPage()
            {
                Title = "Meetings"
            };

            ContentPage aboutPage = new AboutPage()
            {
                Title = "About"
            };

            ((TabbedPage)MainPage).Children.Add(groupsPage);
            ((TabbedPage)MainPage).Children.Add(meetingsPage);
            ((TabbedPage)MainPage).Children.Add(aboutPage);
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
