using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class ZoneManager
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
    }
}
