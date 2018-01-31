using SeeAllClassLibrary.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Settings
{
    public class SeeAllSettings
    {
        public int SeeAllId { get; set; }
        public string Transitions { get; set; }
        public int MicroDowntime { get; set; }
        public int Cycle { get; set; }
        public bool Work { get; set; }

        public int? PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}
