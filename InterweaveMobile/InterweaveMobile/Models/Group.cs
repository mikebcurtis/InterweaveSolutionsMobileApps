using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveMobile.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<int> ParticipantIds { get; set; }
        public IEnumerable<Participant> Participants { get; set; }
    }
}
