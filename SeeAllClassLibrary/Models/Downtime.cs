using SeeAllClassLibrary.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Models
{
    public class Downtime
    {
        public long DowntimeId { get; set; }
        public long DatetimeId { get; set; }
        public string CycleTime { get; set; }
        public string DowntimeValue { get; set; }
        public bool? MicroDowntime { get; set; }
        public bool? Transition { get; set; }

        public int PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}
