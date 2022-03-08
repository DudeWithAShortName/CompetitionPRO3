using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class MechanicPrimary
    {
        public int Id { get; set; }
        public int TeamParticipantId { get; set; }
        public int WorkPostId { get; set; }
        public int JuryMemberId { get; set; }
        public string Points { get; set; }
        public virtual TeamParticipant TeamParticipant { get; set; }
        public virtual JuryMember JuryMember { get; set; }
    }
}
