using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.TeamParticipants = new HashSet<TeamParticipant>();
        }
        public int Id { get; set; }
        public int Number { get; set; }
        public string ShortName { get; set; }
        public virtual ICollection<TeamParticipant> TeamParticipants { get; set; }
    }
}
