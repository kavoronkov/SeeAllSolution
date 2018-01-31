using SeeAllClassLibrary.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Settings
{
    public class PLCSettings
    {
        public int PLCId { get; set; }
        public string PLCIp { get; set; }
        public int RackCpu { get; set; }
        public int SlotCpu { get; set; }
        public int DataBlockLimit { get; set; }
        public int DataBlockDatetime { get; set; }

        public int? PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}
