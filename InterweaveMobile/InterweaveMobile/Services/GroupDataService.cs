using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveMobile.Models;
using InterweaveMobile.Repositories;

namespace InterweaveMobile.Services
{
    public class GroupDataService : IGroupService
    {
        private IGroupRepository _groupRepository;
        private IParticipantRepository _participantRepository;

        public GroupDataService(IGroupRepository groupRepository, IParticipantRepository participantRepository)
        {
            _groupRepository = groupRepository;
            _participantRepository = participantRepository;
        }

        public async Task<IEnumerable<Group>> GetAllGroupsAsync()
        {
            var groups = await _groupRepository.GetAllAsync();
            foreach (var group in groups)
            {
                List<Participant> participants = new List<Participant>();
                foreach (Guid id in group.ParticipantIds)
                {
                    participants.Add(await _participantRepository.GetParticipantDetailsAsync(id));
                }
                group.Participants = participants;
            }

            return groups;
        }
    }
}
