using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class BestDriver
    {
        public int Id { get; set; }
        public int JuryMemberId { get; set; }
        public int TeamParticipantId { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan PenaltySeconds { get; set; }
        public TimeSpan TotalTime { get; set; }
        public int TotalPoints { get; set; }
        public virtual TeamParticipant TeamParticipants { get; set; }
        public virtual Jury Jury { get; set; }
    }
}
