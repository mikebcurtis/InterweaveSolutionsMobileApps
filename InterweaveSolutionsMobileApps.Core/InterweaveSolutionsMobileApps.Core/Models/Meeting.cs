using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DayAndTime { get; set; }
        public Group ParticipantGroup { get; set; }
        public IEnumerable<Participant> Attendees { get; set; }
        public IEnumerable<Participant> FeePayers { get; set; }
        public IEnumerable<Participant> CommittmentHolders { get; set; }
    }
}
