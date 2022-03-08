using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Models
{
    public class WorkPostInputModel
    {
        public int PostNumber { get; set; }
        public int TeamNumber { get; set; }
        public string TeamName { get; set; }
        public int JuryMemberId { get; set; }
        public IEnumerable<ParticipantInputModel> Participants { get; set; }
    }
}
