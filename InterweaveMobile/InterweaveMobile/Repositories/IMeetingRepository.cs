using InterweaveMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveMobile.Repositories
{
    public interface IMeetingRepository
    {
        Task<IEnumerable<Meeting>> GetAllAsync();
        Task<Meeting> GetByIdAsync(Guid id);
        Task<Boolean> UpdateMeeting(Meeting updatedMeeting);
    }
}
