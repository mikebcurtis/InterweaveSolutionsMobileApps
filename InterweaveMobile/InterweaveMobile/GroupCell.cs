using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InterweaveMobile
{
    class GroupCell : ViewCell
    {
        public GroupCell()
        {
            Label titleLabel = new Label
            {
                FontAttributes = FontAttributes.Bold
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Name"));

            ListView participantListView = new ListView();

            participantListView.SetBinding(ListView.ItemsSourceProperty, new Binding("Participants"));

            View = new StackLayout
            {
                Children = { titleLabel, participantListView },
                Orientation = StackOrientation.Vertical
            };
        }
    }
}
