using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterweaveSolutionsMobileApps.Core.Models;

namespace InterweaveSolutionsMobileApps.Core.Repositories
{
    public class DemoParticipantRepository : IParticipantRepository
    {
        private static readonly List<Participant> demoParticipants = new List<Participant>()
        {
                new Participant
                {
                    Id = 0,
                    Name = "Eula Hoffman",
                    Email = "eulahoffman@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = 1,
                    Name = "Andres Reed",
                    Email = "andresreed@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = 2,
                    Name = "Daisy Owen",
                    Email = "daisyowen@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = 3,
                    Name = "Leslie Reyes",
                    Email = "lesliereyes@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = 4,
                    Name = "Nick Bailey",
                    Email = "nickbailey@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                },
                new Participant
                {
                    Id = 5,
                    Name = "Oliver Mcgee",
                    Email = "olivermcgee@email.com",
                    Phone = "(123) 456-7890",
                    Location = "New York City, New York",
                    Country = "USA"
                }
            };

        public Task<Participant> GetParticipantDetailsAsync(int id)
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
