using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveMobile.Models;

namespace InterweaveMobile.Repositories
{
    public class DemoParticipantRepository : IParticipantRepository
    {
        public static readonly Guid participant0Id = Guid.NewGuid();
        public static readonly Guid participant1Id = Guid.NewGuid();
        public static readonly Guid participant2Id = Guid.NewGuid();
        public static readonly Guid participant3Id = Guid.NewGuid();
        public static readonly Guid participant4Id = Guid.NewGuid();
        public static readonly Guid participant5Id = Guid.NewGuid();

        private static readonly List<Participant> demoParticipants = new List<Participant>()
        {
                new Participant
                {
                    Id = participant0Id,
                    Name = "Eula Hoffman",
                    Email = "eulahoffman@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = participant1Id,
                    Name = "Andres Reed",
                    Email = "andresreed@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = participant2Id,
                    Name = "Daisy Owen",
                    Email = "daisyowen@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = participant3Id,
                    Name = "Leslie Reyes",
                    Email = "lesliereyes@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = participant4Id,
                    Name = "Nick Bailey",
                    Email = "nickbailey@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = participant5Id,
                    Name = "Oliver Mcgee",
                    Email = "olivermcgee@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                }
            };

        public Task<Participant> GetParticipantDetailsAsync(Guid id)
        {
            return new Task<Participant>(() => 
                {
                    return demoParticipants
                        .Where<Participant>(p => p.Id == id)
                        .First<Participant>();
                }
            );
        }
    }
}
