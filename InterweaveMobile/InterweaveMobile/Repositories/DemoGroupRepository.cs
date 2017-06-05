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
                Id = 0,
                Name = "Grupo A",
                ParticipantIds = new List<int>() { 0, 1, 2, 3 }
            },
            new Group
            {
                Id = 1,
                Name = "Grupo B",
                ParticipantIds = new List<int>() { 4, 5 }
            }
        };

        public Task<IEnumerable<Group>> GetAllAsync()
        {
            return new Task<IEnumerable<Group>>(() => { return demoGroups; });
        }

        public Task<Group> GetById(int id)
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
