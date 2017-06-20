using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InterweaveMobile
{
	public class AboutPage : ContentPage
	{
		public AboutPage ()
		{
            Icon = "settings_icon.png";

			Content = new StackLayout {
				Children = {
					new Label { Text = "About goes here" }
				}
			};
		}
	}
}