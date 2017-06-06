using System;
using System.Collections.Generic;
using System.Text;

namespace InterweaveMobile.Repositories
{
    class GroupRepositoryFactory
    {
        public static IGroupRepository GetGroupRepository()
        {
            return new DemoGroupRepository();
        }
    }
}
