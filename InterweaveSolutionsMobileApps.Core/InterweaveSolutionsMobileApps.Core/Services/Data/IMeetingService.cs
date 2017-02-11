using InterweaveSolutionsMobileApps.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core.Services.Data
{
    public interface IMeetingService
    {
        Task<IEnumerable<Meeting>> GetAllMeetingsAsync();
    }
}
