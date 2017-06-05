using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveMobile.Models;

namespace InterweaveMobile.Repositories
{
    public class DemoMeetingRepository : IMeetingRepository
    {
        private static readonly List<Meeting> demoMeetings = new List<Meeting>()
        {
            new Meeting
            {
                Id = 0,
                Name = "Reunion con Grupo A",
                Location = "Parque Primavera",
                DayAndTime = DateTime.Now,
                ParticipantGroupId = 0,
                AttendeeIds = new List<int>() { 1, 2, 3 },
                CommittmentHolderIds = new List<int>() { 1, 2 },
                FeePayerIds = new List<int>() { 2, 3 }
            },
            new Meeting
            {
                Id = 1,
                Name = "Reunion con Grupo B",
                Location = "Plaza de Felicidad",
                DayAndTime = DateTime.Now,
                ParticipantGroupId = 1,
                AttendeeIds = new List<int>() { 4, 5 },
                CommittmentHolderIds = new List<int>() { 4 },
                FeePayerIds = new List<int>() { 5 }
            },
            new Meeting
            {
                Id = 2,
                Name = "Reunion con Grupo A",
                Location = "Parque Primavera",
                DayAndTime = DateTime.Now,
                ParticipantGroupId = 0,
                AttendeeIds = new List<int>() { 0, 2, 3 },
                CommittmentHolderIds = new List<int>() { 2 },
                FeePayerIds = new List<int>()
            }
        };

        public Task<IEnumerable<Meeting>> GetAllAsync()
        {
            return new Task<IEnumerable<Meeting>>(() => { return demoMeetings; });
        }

        public Task<Meeting> GetByIdAsync(int id)
        {
            return new Task<Meeting>(() => 
                {
                    return demoMeetings
                        .Where<Meeting>((x) => x.Id == id)
                        .First<Meeting>();
                }
            );
        }
    }
}
