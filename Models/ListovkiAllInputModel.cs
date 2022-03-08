using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Models
{
    public class ListovkiAllInputModel
    {
        public ListovkiAllInputModel()
        {
            this.ListovkiInputModels = new HashSet<ListovkiInputModel>();
        }
        public IEnumerable<ListovkiInputModel> ListovkiInputModels { get; set; }
    }
}
