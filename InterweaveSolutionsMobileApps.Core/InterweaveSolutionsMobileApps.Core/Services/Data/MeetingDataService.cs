﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveSolutionsMobileApps.Core.Models;
using InterweaveSolutionsMobileApps.Core.Repositories;

namespace InterweaveSolutionsMobileApps.Core.Services.Data
{
    public class MeetingDataService : IMeetingService
    {
        private IGroupRepository _groupRepository;
        private IMeetingRepository _meetingRepository;
        private IParticipantRepository _participantRepository;

        public MeetingDataService(IMeetingRepository meetingRepository, IGroupRepository groupRepository, IParticipantRepository participantRepository)
        {
            _meetingRepository = meetingRepository;
            _groupRepository = groupRepository;
            _participantRepository = participantRepository;
        }

        public async Task<IEnumerable<Meeting>> GetAllMeetingsAsync()
        {
            var meetings = await _meetingRepository.GetAllAsync();
            foreach (var meeting in meetings)
            {
                meeting.ParticipantGroup = await _groupRepository.GetById(meeting.ParticipantGroupId);

                List<Participant> attendees = new List<Participant>();
                foreach (int id in meeting.AttendeeIds)
                {
                    attendees.Add(await _participantRepository.GetParticipantDetailsAsync(id));
                }
                meeting.Attendees = attendees;

                List<Participant> feepayers = new List<Participant>();
                foreach (int id in meeting.FeePayerIds)
                {
                    feepayers.Add(await _participantRepository.GetParticipantDetailsAsync(id));
                }
                meeting.FeePayers = feepayers;

                List<Participant> committers = new List<Participant>();
                foreach (int id in meeting.CommittmentHolderIds)
                {
                    committers.Add(await _participantRepository.GetParticipantDetailsAsync(id));
                }
                meeting.CommittmentHolders = committers;
            }

            return meetings;
        }
    }
}
