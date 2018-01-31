using SeeAllClassLibrary.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Models
{
    public class Datetime
    {
        public int DatetimeId { get; set; }
        public DateTime DateTimeValue { get; set; }

        public int? PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}
