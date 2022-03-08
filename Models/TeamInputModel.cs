using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Models
{
    public class TeamInputModel
    {
        public TeamInputModel()
        {
            this.Names = new HashSet<string>();
        }
        public IEnumerable<string> Names { get; set; }
        public string LeaderName { get; set; }
        public string ShortSchoolName { get; set; }
    }
}
