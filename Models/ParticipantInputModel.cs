using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Models
{
    public class ParticipantInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string TeamName { get; set; }
        public IEnumerable<int> Points { get; set; }
    }
}
