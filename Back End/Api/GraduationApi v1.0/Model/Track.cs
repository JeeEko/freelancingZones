using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Track
    {
        //prop
        public int ID { get; set; }
        public String Name { get; set; }

        //relations
        public ICollection<Intern> Interns { get; set; }
    }
}
