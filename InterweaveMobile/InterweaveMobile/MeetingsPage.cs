using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace InterweaveMobile
{
	public class MeetingsPage : ContentPage
	{
		public MeetingsPage ()
		{
            Icon = "meeting_icon.png";

			Content = new StackLayout {
				Children = {
					new Label { Text = "Meetings go here" }
				}
			};
		}
	}
}