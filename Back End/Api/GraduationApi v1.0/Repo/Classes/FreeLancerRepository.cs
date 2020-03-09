using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Repo.Classes
{
    public class FreeLancerRepository:MainOperation<Freelancer>,IFreelancer
    {

        public FreeLancerRepository(FreeLanceZoneDbContext ctx) : base(ctx)
        {

        }

        public IEnumerable<Freelancer> GetForOpinion()
        {
            var freelancers = ctx.Freelancers.Where(f => f.Opinion != null).Take(8).ToList();
            return freelancers;
        }

        public IEnumerable<Freelancer> GetForStories()
        {
            var freelancers = ctx.Freelancers.Where(f => f.Brief != null).Take(8).ToList();
            return freelancers;
        }
    }
}
