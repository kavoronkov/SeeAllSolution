using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Directories
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public int WorkshopId { get; set; }
        public virtual Workshop Workshop { get; set; }

        public virtual ICollection<Point> Points { get; set; }

        public Department()
        {
            Points = new List<Point>();
        }
    }
}
