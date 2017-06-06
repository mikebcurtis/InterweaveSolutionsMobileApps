using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveMobile.Models
{
    public class Meeting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DayAndTime { get; set; }
        public Guid ParticipantGroupId { get; set; }
        public Group ParticipantGroup { get; set; }
        public IEnumerable<Guid> AttendeeIds { get; set; }
        public IEnumerable<Guid> FeePayerIds { get; set; }
        public IEnumerable<Guid> CommittmentHolderIds { get; set; }
        public List<Participant> Attendees { get; set; }
        public List<Participant> FeePayers { get; set; }
        public List<Participant> CommittmentHolders { get; set; }
    }
}
