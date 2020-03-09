using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Answer
    {
        //props
        public int ID { get; set; }
        public String AnswerBody { get; set; }
        [ForeignKey("Question")]
        public int Question_Id { get; set; }
        [ForeignKey("Intern")]
        public int Intern_Id { get; set; }

        //relations
        public virtual Question Question { get; set; }
        public virtual Intern Intern { get; set; }
    }
}
