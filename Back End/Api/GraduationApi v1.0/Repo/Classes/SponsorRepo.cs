using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Repo.Classes
{
    public class SponsorRepo : MainOperation<SponsorRepo>, Isponsor
    {
        public SponsorRepo(FreeLanceZoneDbContext ctx) : base(ctx)
        {

        }
        public IEnumerable<string> GetAllImages()
        {
            return ctx.Sponsors.Select(x => x.ImageName);
        }
    }
}
