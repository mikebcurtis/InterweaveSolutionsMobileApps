using InterweaveSolutionsMobileApps.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core.Repositories
{
    public interface IParticipantRepository
    {
        Task<Participant> GetParticipantDetailsAsync(int id);
    }
}
