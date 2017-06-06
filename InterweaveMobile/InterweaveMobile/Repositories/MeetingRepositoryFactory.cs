using System;
using System.Collections.Generic;
using System.Text;

namespace InterweaveMobile.Repositories
{
    class MeetingRepositoryFactory
    {
        public static IMeetingRepository GetMeetingRepository()
        {
            return new DemoMeetingRepository();
        }
    }
}
