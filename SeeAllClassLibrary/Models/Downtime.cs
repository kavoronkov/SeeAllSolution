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
        public int DowntimeId { get; set; }
        public DateTime DowntimeValue { get; set; }

        public int? PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}
