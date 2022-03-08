using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class BestMechanic
    {
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public int JuryLeaderPoints { get; set; }
        public int JuryMember1Points { get; set; }
        public int JuryMember2Points { get; set; }
        public int JuryMember3Points { get; set; }
        public int WorkPostNumber { get; set; }
        public int AveragePoints { get; set; }
        public int Ranking { get; set; }
        public virtual TeamParticipant TeamParticipants { get; set; }
    }
}
