using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Intern
    {
        //props
        public int ID { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public int GraduationYear { get; set; }
        public bool ITI_Trainee { get; set; }
        public Double Rate { get; set; }
        [ForeignKey("Faculty")]
        public int Faculty_Id { get; set; }
        [ForeignKey("University")]
        public int University_Id { get; set; }
        [ForeignKey("Zone")]
        public int Zone_Id { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        [ForeignKey("ITIProgram")]
        public int ITIProgram_Id { get; set; }
        [ForeignKey("Intake")]
        public int Intake_Id { get; set; }
        [ForeignKey("Track")]
        public int Track_Id { get; set; }
        [ForeignKey("Branch")]
        public int Branch_Id { get; set; }

        //relations
        public virtual Zone Zone { get; set; }
        public virtual User User { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual University University { get; set; }
        public virtual ITIProgram ITIProgram { get; set; }
        public virtual Intake Intake { get; set; }
        public virtual Track Track { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
