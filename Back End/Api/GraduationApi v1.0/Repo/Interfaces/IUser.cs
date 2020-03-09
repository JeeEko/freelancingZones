using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Repo
{
    interface IUser
    {
        
        
        User GetByMail_Password(String Mail, String Password);
        User Add( User user);
        User GetByMail(String Email);
        
    }
}
