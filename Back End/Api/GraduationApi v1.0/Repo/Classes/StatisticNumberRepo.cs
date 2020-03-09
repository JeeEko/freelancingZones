using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Repo.Classes
{
    public class StatisticNumberRepo : MainOperation<StatisticNumber>,IstatisticNumber
    {
        public StatisticNumberRepo(FreeLanceZoneDbContext ctx) : base(ctx)
        {

        }
        

        public IEnumerable<string> GetAllDescriptionArranged()
        {
            return ctx.StatisticNumbers.OrderByDescending(x => x.Number).Select(x => x.Description);

        }

        public IEnumerable<int> GetAllNumberArranged()
        {
            return ctx.StatisticNumbers.OrderByDescending(x => x.Number).Select(x => x.Number);

        }
    }
}
