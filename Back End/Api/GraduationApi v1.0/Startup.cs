﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationApi_v1._0.Helpers;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo;
using GraduationApi_v1._0.Repo.Classes;
using GraduationApi_v1._0.Repo.Interfaces;
using GraduationApi_v1._0.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace GraduationApi_v1._0
{
    public class Startup
    {
        private object appSettingsSection;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            
            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            //});

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //.AddJsonOptions(options =>
            //{
            //    options.SerializerSettings.Formatting = Formatting.Indented;
            //});

            services.AddDbContext<FreeLanceZoneDbContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection")));

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            // configure DI for application services
            services.AddScoped<UserRepository>();
            services.AddScoped<FileUploadService>();
            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<ZoneRepository>();
            //services.AddScoped<InternRepo>();
            services.AddScoped<MainOperation<Intern>>();
            services.AddScoped<MainOperation<Zone>>();
            services.AddScoped<MainOperation<Mentor>>();
            //services.AddScoped<MainOperation<Freelancer>>();
            services.AddScoped<MainOperation<ZoneManager>>();
            services.AddScoped<StatisticNumberRepo>();

            services.AddScoped<MainOperation<Sponsor>>();

            services.AddScoped<ZoneServise>();
            services.AddScoped<SponsorService>();
    
            services.AddScoped<FreeLancerRepository>();
            services.AddScoped<BannerImageRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            // global cors policy
            app.UseCors(x => x 
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            
            //app.UseCors(builder =>
            //    builder.WithOrigins("http://localhost:4200")
            //        .AllowAnyHeader()
            //        .AllowAnyMethod());

            

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvc();
            //jeeeko2
            //omar2
            
        }
    }
}
