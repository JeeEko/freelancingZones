using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;

namespace GraduationApi_v1._0.Repo.Classes
{
    public class UserRepository :MainOperation<User>,IUser
    {
        
        public UserRepository(FreeLanceZoneDbContext ctx):base(ctx)
        {
            
        }

        public User Add(User user)
        {
            ctx.Users.Add(user);
            ctx.SaveChanges();
            return user;
        }
        public User GetByMail_Password(string Mail, string Password)
        {
            var user = ctx.Users.SingleOrDefault(u => u.Email == Mail && u.Password == Password);
            return user;
        }
        public User GetByMail(String Email) {
            var user = ctx.Users.SingleOrDefault(u => u.Email == Email);
            return user;
        }

    }
}
