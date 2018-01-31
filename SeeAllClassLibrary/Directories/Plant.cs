using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeAllClassLibrary.Directories
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string PlantName { get; set; }

        public virtual ICollection<Workshop> Workshops { get; set; }

        public Plant()
        {
            Workshops = new List<Workshop>();
        }
    }
}
