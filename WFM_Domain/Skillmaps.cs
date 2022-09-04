using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFM_Domain
{
    public class Skillmaps
    {
        public int employee_id { get; set; }
        public Employees employees { get; set; }
        public int skillid { get; set; }
        public Skills skills { get; set; }
    }
}
