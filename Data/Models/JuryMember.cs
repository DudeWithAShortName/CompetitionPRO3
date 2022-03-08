using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Data.Models
{
    public class JuryMember //4
    {
        public int Id { get; set; }
        public int JuryId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public virtual Jury Jury { get; set; }
    }
}
