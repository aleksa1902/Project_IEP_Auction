using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectIepAuction.Factories;
using Quartz;
using ProjectIepAuction.Hubs;


namespace ProjectIepAuction
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProjectIepAuctionContext>(
                options => options.UseSqlServer(this.Configuration.GetConnectionString("ProjectIepAuctionDB"))
            );

            services.AddIdentity<User, IdentityRole>(
                options => {
                    options.User.RequireUniqueEmail = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = true;
                    options.Password.RequiredLength = 8;
                }


            ).AddEntityFrameworkStores<ProjectIepAuctionContext>();

            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(Startup));

            services.ConfigureApplicationCookie (
                options => {
                    options.LoginPath = "/User/LogIn";
                    options.AccessDeniedPath = "/Home/Error";
                }
            );

            services.AddQuartz(
                q =>
                {
                    q.SchedulerId = "Scheduler-Core";
                    //q.SchedulerName = "QuartzScheduler";
                    q.UseMicrosoftDependencyInjectionJobFactory(options =>{
                        // if we don't have the job in DI, allow fallback to configure via default constructor
                        options.AllowDefaultConstructor = true;
                    });
                    q.UseSimpleTypeLoader();
                    q.UseInMemoryStore();
                    q.UseDefaultThreadPool(tp =>
                    {
                        tp.MaxConcurrency = 10;
                    });
 
                    
                }
            );

            services.AddScoped<IUserClaimsPrincipalFactory<User>, ClaimFactory>();
            services.AddSignalR();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<BidHub>("/bidhub");
                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}