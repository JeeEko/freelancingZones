using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Question
    {
        //props
        public int ID { get; set; }
        public String QuestionBody { get; set; }

        //relations
        //public virtual ICollection<Answer> Answers { get; set; }
    }
}
