using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetCoreSaaS.Core;
using NetCoreSaaS.Data.Entities.Catalog;
using NetCoreSaaS.WebHost.Infrastructures.Extensions;
using NetCoreSaaS.WebHost.Infrastructures.Helpers.DbHelper;
using NetCoreSaaS.WebHost.Infrastructures.TenantResolver;
using NetCoreSaaS.WebHost.Policies;
using NetCoreSaaS.WebHost.Services;
using AppPermissions = NetCoreSaaS.Core.ApplicationPermissions;

namespace NetCoreSaaS.WebHost
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            
            var migrationAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            services.AddContexts(Configuration, migrationAssembly);

            services.AddIdentityService();

            services.AddMultitenancy<Tenant, TenantResolver>();
            services.AddMvc();

            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy(AuthPolicies.ViewUserByUserIdPolicy, policy => policy.Requirements.Add(new ViewUserByIdRequirement()));

                options.AddPolicy(AuthPolicies.ViewUsersPolicy, policy => policy.RequireClaim(CustomClaimTypes.Permission, AppPermissions.ViewUsers));

                options.AddPolicy(AuthPolicies.ManageUserByUserIdPolicy, policy => policy.Requirements.Add(new ManageUserByIdRequirement()));

                options.AddPolicy(AuthPolicies.ManageUsersPolicy, policy => policy.RequireClaim(CustomClaimTypes.Permission, AppPermissions.ManageUsers));

                options.AddPolicy(AuthPolicies.ViewRoleByRoleNamePolicy, policy => policy.Requirements.Add(new ViewRoleByNameRequirement()));

                options.AddPolicy(AuthPolicies.ViewRolesPolicy, policy => policy.RequireClaim(CustomClaimTypes.Permission, AppPermissions.ViewRoles));

                options.AddPolicy(AuthPolicies.AssignRolesPolicy, policy => policy.Requirements.Add(new AssignRolesRequirement()));

                options.AddPolicy(AuthPolicies.ManageRolesPolicy, policy => policy.RequireClaim(CustomClaimTypes.Permission, AppPermissions.ManageRoles));
            });

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMultitenancy<Tenant>();
            app.UseAuthentication();
            DbInitailizer.InitializeDatabase(app);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
