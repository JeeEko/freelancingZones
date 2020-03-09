using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Services
{
    public interface IUserService
    {
        UserVm Authenticate(string username, string password);
        UserVm register(RegisterViewModel register);
    }
}
