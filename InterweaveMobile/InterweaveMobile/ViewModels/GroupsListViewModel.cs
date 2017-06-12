using InterweaveMobile.Models;
using InterweaveMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveMobile.ViewModels
{
    public class GroupsListViewModel : BaseViewModel
    {
        private IGroupService _groupService;

        public GroupsListViewModel()
        {
            _groupService = GroupServiceFactory.GetGroupService();
        }

        protected override async Task InitializeAsync()
        {
        }

        public async Task<IEnumerable<Group>> GetGroupsAsync()
        {
            return await _groupService.GetAllGroupsAsync();
        }
    }
}
