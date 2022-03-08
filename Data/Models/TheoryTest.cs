using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class TheoryTest
    {
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public int PointsMPS { get; set; }
        public int PointsMechanic { get; set; }
        public virtual TeamParticipant TeamParticipants { get; set; }
    }
}
