using GraduationApi_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Repo.Interfaces
{
    interface IFreelancer
    {
        IEnumerable<Freelancer> GetForStories();
        IEnumerable<Freelancer> GetForOpinion();
    }
}
