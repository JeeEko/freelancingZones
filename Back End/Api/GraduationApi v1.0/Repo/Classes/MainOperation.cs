using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Repo.Classes
{
    public class MainOperation<T> : IMainOperation<T> where T : class
    {
        public  FreeLanceZoneDbContext ctx=null;
        public DbSet<T> table=null;
        public MainOperation(FreeLanceZoneDbContext ctx)
        {
            this.ctx = ctx;
            table = ctx.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            ctx.Entry(obj).State = EntityState.Modified;
        }
    }
}
