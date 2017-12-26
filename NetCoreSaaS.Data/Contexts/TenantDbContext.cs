using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreSaaS.Data.Contexts;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NetCoreSaaS.Data.Entities.Catalog;
using NetCoreSaaS.Data.Entities.Tenant;
using NetCoreSaaS.Data.Infrastrutures.Extensions;

namespace NetCoreSaaS.Data.Contexts
{
    public sealed class TenantDbContext : IdentityDbContext<TenantUser>
    {

        private readonly Tenant _currentTenant;
        public DbSet<TenantDetails> TenantDetails { get; set; }

        public TenantDbContext(Tenant currentTenant)
        {
            _currentTenant = currentTenant;

            // Database.EnsureCreated();

            Database.Migrate();
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                    entry.Property("UpdatedDate").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property("UpdatedDate").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    entry.Property("DeletedDate").CurrentValue = DateTime.Now;
                    entry.Property("IsDeleted").CurrentValue = true;
                    entry.State = EntityState.Detached;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_currentTenant != null)
            {
                optionsBuilder.UseSqlServer(_currentTenant.GetConnectionString(), options => options.MigrationsAssembly("NetCoreSaaS.WebHost"));
            }

            base.OnConfiguring(optionsBuilder);
        }

    }

    public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<TenantDbContext>
    {
        private DbContextOptionsBuilder<TenantDbContext> _optionsBuilder;

        public TemporaryDbContextFactory()
        {

        }
        public TemporaryDbContextFactory(DbContextOptionsBuilder<TenantDbContext> optionsBuilder)
        {
            this._optionsBuilder = optionsBuilder ?? throw new ArgumentNullException(nameof(optionsBuilder));
        }



        public TenantDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            _optionsBuilder = new DbContextOptionsBuilder<TenantDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            _optionsBuilder.UseSqlServer(connectionString, options => options.MigrationsAssembly("NetCoreSaaS.WebHost"));
            return new TenantDbContext(new Tenant() { DbConnectionString = connectionString });
        }
    }
}
