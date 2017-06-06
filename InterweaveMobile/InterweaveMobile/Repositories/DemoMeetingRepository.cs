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
        private static List<Meeting> demoMeetings = new List<Meeting>()
        {
            new Meeting
            {
                Id = new Guid(),
                Name = "Group A Meeting",
                Location = "Parque Primavera",
                DayAndTime = new DateTime(2017, 3, 15, 12, 0, 0, 0),
                ParticipantGroupId = new Guid(),
                AttendeeIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant1Id,
                    DemoParticipantRepository.participant2Id,
                    DemoParticipantRepository.participant3Id
                },
                CommittmentHolderIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant1Id,
                    DemoParticipantRepository.participant2Id
                },
                FeePayerIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant2Id,
                    DemoParticipantRepository.participant3Id
                }
            },
            new Meeting
            {
                Id = new Guid(),
                Name = "Group B Meeting",
                Location = "Plaza de Felicidad",
                DayAndTime = new DateTime(2017, 3, 18, 9, 30, 0, 0),
                ParticipantGroupId = new Guid(),
                AttendeeIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant4Id,
                    DemoParticipantRepository.participant5Id
                },
                CommittmentHolderIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant4Id
                },
                FeePayerIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant5Id
                }
            },
            new Meeting
            {
                Id = new Guid(),
                Name = "Group A Meeting",
                Location = "Parque Primavera",
                DayAndTime = new DateTime(2017, 3, 22, 12, 0, 0, 0),
                ParticipantGroupId = new Guid(),
                AttendeeIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant0Id,
                    DemoParticipantRepository.participant2Id,
                    DemoParticipantRepository.participant3Id
                },
                CommittmentHolderIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant2Id
                },
                FeePayerIds = new List<Guid>()
            }
        };

        public Task<IEnumerable<Meeting>> GetAllAsync()
        {
            return new Task<IEnumerable<Meeting>>(() => { return demoMeetings; });
        }

        public Task<Meeting> GetByIdAsync(Guid id)
        {
            return new Task<Meeting>(() => 
                {
                    return demoMeetings
                        .Where<Meeting>((x) => x.Id == id)
                        .First<Meeting>();
                }
            );
        }

        public Task<Boolean> UpdateMeeting(Meeting updatedMeeting)
        {
            bool updated = false;

            for (int i = 0; i < demoMeetings.Count; i++)
            {
                if (demoMeetings[i].Id == updatedMeeting.Id)
                {
                    demoMeetings[i].Id = updatedMeeting.Id;
                    updated = true;
                    break;
                }
            }

            return new Task<Boolean>(() =>
                {
                    return updated;
                }
            );
        }
    }
}
