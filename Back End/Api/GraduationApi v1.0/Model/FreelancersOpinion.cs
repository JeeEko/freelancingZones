using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class FreelancersOpinion
    {
        //props
        public int ID { get; set; }

        [ForeignKey("Freelancer")]
        public int FreelancerId { get; set; }

        //relations
        public virtual Freelancer Freelancer { get; set; }
    }
}
