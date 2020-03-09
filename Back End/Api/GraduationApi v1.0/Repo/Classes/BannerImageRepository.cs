using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Repo.Classes
{
    public class BannerImageRepository : IMainOperation<BannerImages>
    {
        private readonly FreeLanceZoneDbContext ctx;

        public BannerImageRepository(FreeLanceZoneDbContext ctx)
        {
            this.ctx = ctx;
        }
        public void Delete(object id)
        { 
            throw new NotImplementedException(); 
        } 
         
        public IEnumerable<BannerImages> GetAll()
        {     
            return ctx.BannerImages.ToList();
        }
         
        public BannerImages GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(BannerImages obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(BannerImages obj)
        {
            throw new NotImplementedException();
        }
    }
}
