using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveMobile.Models;

namespace InterweaveMobile.Repositories
{
    public class DemoGroupRepository : IGroupRepository
    {
        private static readonly List<Group> demoGroups = new List<Group>()
        {
            new Group
            {
                Id = Guid.NewGuid(),
                Name = "Group A",
                ParticipantIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant0Id,
                    DemoParticipantRepository.participant1Id,
                    DemoParticipantRepository.participant2Id,
                    DemoParticipantRepository.participant3Id
                }
            },
            new Group
            {
                Id = Guid.NewGuid(),
                Name = "Group B",
                ParticipantIds = new List<Guid>()
                {
                    DemoParticipantRepository.participant4Id,
                    DemoParticipantRepository.participant5Id
                }
            }
        };

        public async Task<IEnumerable<Group>> GetAllAsync()
        {
            return demoGroups;
        }

        public Task<Group> GetById(Guid id)
        {
            return new Task<Group>(() =>
                {
                    return demoGroups
                        .Where<Group>(g => g.Id == id)
                        .First<Group>();
                }
            );
        }
    }
}
