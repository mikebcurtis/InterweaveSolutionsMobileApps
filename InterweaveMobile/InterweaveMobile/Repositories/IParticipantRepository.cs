using InterweaveMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveMobile.Repositories
{
    public interface IParticipantRepository
    {
        Task<Participant> GetParticipantDetailsAsync(int id);
    }
}
