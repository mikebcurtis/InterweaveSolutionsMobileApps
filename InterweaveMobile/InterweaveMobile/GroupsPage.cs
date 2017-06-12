using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using InterweaveMobile.ViewModels;
using InterweaveMobile.Models;
using System.Threading.Tasks;

namespace InterweaveMobile
{
	public class GroupsPage : ContentPage
	{
        private GroupsListViewModel _viewModel;

        public GroupsPage ()
		{
            // View Model
            _viewModel = new GroupsListViewModel();

            // General Properties
            Padding = new Thickness(5);

            // Content
            Button newGroupButton = new Button()
            {
                Text = "Add New Group"
            };

            ListView groupsListView = new ListView()
            {
                ItemsSource = new List<Group>(), // display nothing until groups have loaded TODO make this a loading image or something 
                ItemTemplate = new DataTemplate(typeof(GroupCell)),
                HasUnevenRows = true
            };

            _viewModel.GetGroupsAsync().ContinueWith((Task<IEnumerable<Group>> taskResult) => 
            {
                Device.BeginInvokeOnMainThread(() => 
                {
                    groupsListView.ItemsSource = taskResult.Result;
                });
            });

            Content = new StackLayout
            {
                Children =
                {
                    newGroupButton,
                    groupsListView
                }
            };
        }
	}
}