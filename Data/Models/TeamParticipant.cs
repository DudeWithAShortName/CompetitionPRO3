using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class TeamParticipant //2
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
