using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class Jury //3
    {
        public Jury()
        {
            this.JuryMembers = new HashSet<JuryMember>();
        }
        public int Id { get; set; }
        public string JuryCategory { get; set; }
        public ICollection<JuryMember> JuryMembers { get; set; }

    }
}
