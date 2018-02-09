using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Directories
{
    public class Workshop
    {
        public int WorkshopId { get; set; }
        public string WorkshopName { get; set; }

        public int PlantId { get; set; }
        public virtual Plant Plant { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        public Workshop()
        {
            Departments = new List<Department>();
        }
    }
}
