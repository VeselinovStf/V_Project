﻿using ES.Data.Core;
using ES.Data.Identity;
using ES.EstateServices;
using ES.EstateServices.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ES.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            this.Configuration = configuration;
            this.Environment = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configure Login/Logout Path, Cookie Expire Time, auth explisit consent
            ConfigureCookieSettings(services);
            // Change Db name and Connection string name to sute your nead, and more conditions for different envirenment
            ConfigureDbConnectionSettings(services);
            // Identity Settings
            ConfigureIdentitySettings(services);
            // MVC Settings
            ConfigureMvcSettings(services);
            // Register new services
            ConfigureApplicationServicess(services);
        }

        private void ConfigureApplicationServicess(IServiceCollection services)
        {
            // Add new App servicess
            services.AddTransient<IEstateService, EstateService>();
        }

        private void ConfigureMvcSettings(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        private void ConfigureIdentitySettings(IServiceCollection services)
        {
            services.AddIdentity<EstateSystemIdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<EstateSystemDbContext>()
                .AddDefaultTokenProviders();
        }

        private void ConfigureDbConnectionSettings(IServiceCollection services)
        {
            if (Environment.IsDevelopment())
            {
                services.AddDbContext<EstateSystemDbContext>(options =>
                 options.UseSqlServer(
                   Configuration.GetConnectionString("DevelopmentConnectionString")));
            }
            else
            {
                services.AddDbContext<EstateSystemDbContext>(options =>
                 options.UseSqlServer(
                   Configuration.GetConnectionString("ProductionConnectionString")));
            }
        }

        private void ConfigureCookieSettings(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.ConfigureApplicationCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromHours(1);
                    options.LoginPath = "";
                    options.LogoutPath = "";
                    options.Cookie = new CookieBuilder
                    {
                        IsEssential = true
                    };
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseStaticFiles();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
                app.UseHttpsRedirection();
                app.UseStaticFiles();
                app.UseCookiePolicy();
            }

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}