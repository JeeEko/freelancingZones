using GraduationApi_v1._0.Helpers;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;
using GraduationApi_v1._0.Repo.Classes;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Services
{
    public class UserService:IUserService
    {
        private readonly AppSettings appSettings;
        private readonly UserRepository userRepository;
        private readonly FreeLanceZoneDbContext context;
        private readonly FileUploadService fileUploadService;

        public UserService(IOptions<AppSettings> _appSettings, UserRepository userRepository,FreeLanceZoneDbContext context,FileUploadService fileUploadService)
        {
            this.appSettings = _appSettings.Value;
            this.userRepository = userRepository;
            this.context = context;
            this.fileUploadService = fileUploadService;
        }

        public UserVm Authenticate(string Email, string password)
        {
            
            var user = userRepository.GetByMail_Password(Email, password);


            // return null if user not found
            if (user == null)
                return null;
            var role = context.Roles.Where(r => r.ID == user.Role_id).FirstOrDefault();

            UserVm uservm = new UserVm();
            uservm.Email = user.Email;
            uservm.ID = user.ID;
            uservm.ImageUrl = user.ImageUrl;
            uservm.PhoneNumber = user.PhoneNumber;
            uservm.Role = role.Name;
            uservm.UserName = user.UserName;
            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, uservm.ID.ToString()),
                    new Claim(ClaimTypes.Role, uservm.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            uservm.Token = tokenHandler.WriteToken(token);

            

            return uservm;
        }

        public UserVm register(RegisterViewModel register)
        {
            var role = context.Roles.Where(r => r.Name == register.Role).FirstOrDefault();
            User user = new User();
            user.Email = register.Email;
            user.Password = Encrypt.GenerateSha256Hash( register.Password);
            user.PhoneNumber = register.PhoneNumber;
            user.Role = role;
            user.Role_id = role.ID;
            user.UserName = register.FName + register.LName;
            if (register.ImageUrl!=null)
            {
                user.ImageUrl = fileUploadService.upload(register.ImageUrl);
            }
            //else add a profile avatar image
            
            var createduser =userRepository.Add(user);
            return Authenticate(createduser.Email, createduser.Password);
        }

    }
}
