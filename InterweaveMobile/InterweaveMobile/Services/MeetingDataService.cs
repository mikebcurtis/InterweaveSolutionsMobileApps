using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveMobile.Models;
using InterweaveMobile.Repositories;

namespace InterweaveMobile.Services
{
    public class MeetingDataService : IMeetingService
    {
        private IGroupRepository _groupRepository;
        private IMeetingRepository _meetingRepository;
        private IParticipantRepository _participantRepository;

        public MeetingDataService()
        {
            _meetingRepository = MeetingRepositoryFactory.GetMeetingRepository();
            _groupRepository = GroupRepositoryFactory.GetGroupRepository();
            _participantRepository = ParticipantRepositoryFactory.GetParticipantRepository();
        }

        public async Task<IEnumerable<Meeting>> GetAllMeetingsAsync()
        {
            IEnumerable<Meeting> meetings = await _meetingRepository.GetAllAsync();
            foreach (var meeting in meetings)
            {
                meeting.ParticipantGroup = await _groupRepository.GetById(meeting.ParticipantGroupId);

                List<Participant> attendees = new List<Participant>();
                foreach (Guid id in meeting.AttendeeIds)
                {
                    attendees.Add(await _participantRepository.GetParticipantDetailsAsync(id));
                }
                meeting.Attendees = attendees;

                List<Participant> feepayers = new List<Participant>();
                foreach (Guid id in meeting.FeePayerIds)
                {
                    feepayers.Add(await _participantRepository.GetParticipantDetailsAsync(id));
                }
                meeting.FeePayers = feepayers;

                List<Participant> committers = new List<Participant>();
                foreach (Guid id in meeting.CommittmentHolderIds)
                {
                    committers.Add(await _participantRepository.GetParticipantDetailsAsync(id));
                }
                meeting.CommittmentHolders = committers;
            }

            return meetings;
        }

        public async Task<Meeting> UpdateMeetingAsync()
        {
            throw new NotImplementedException();
        }
    }
}
