using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class ITIProgram
    {
        //props
        public int ID { get; set; }
        public String Name { get; set; }

        //relations
        public virtual ICollection<Intern> Interns { get; set; }
    }
}
