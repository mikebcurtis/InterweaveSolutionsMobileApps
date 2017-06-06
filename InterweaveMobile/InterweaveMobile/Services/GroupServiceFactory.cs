using System;
using System.Collections.Generic;
using System.Text;

namespace InterweaveMobile.Services
{
    class GroupServiceFactory
    {
        public static IGroupService GetGroupService()
        {
            return new GroupDataService();
        }
    }
}
