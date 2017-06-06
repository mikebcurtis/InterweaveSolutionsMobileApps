using System;
using System.Collections.Generic;
using System.Text;

namespace InterweaveMobile.Services
{
    class MeetingServiceFactory
    {
        public static IMeetingService GetMeetingService()
        {
            return new MeetingDataService();
        }
    }
}
