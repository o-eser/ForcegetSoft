using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Concrete;
using ForcegetSoft.Core.Entities.Concrete.Identity;
using ForcegetSoft.DataAccess.Persistence.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForcegetSoft.DataAccess.Persistence
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public const string ConnectionName = "DefaultConnection";
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Incoterm> Incoterms { get; set; }
        public DbSet<Mode> Modes { get; set; }
        public DbSet<MovementType> MovementTypes { get; set; }
        public DbSet<PackageType> PackageTypes { get; set; }
        public DbSet<Unit1> Unit1s { get; set; }
        public DbSet<Unit2> Unit2s { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OfferConfig());
            builder.ApplyConfiguration(new CityConfig());
            builder.ApplyConfiguration(new CountryConfig());
            builder.ApplyConfiguration(new IncotermConfig());
            builder.ApplyConfiguration(new ModeConfig());
            builder.ApplyConfiguration(new MovementTypeConfig());
            builder.ApplyConfiguration(new PackageTypeConfig());
            builder.ApplyConfiguration(new Unit1Config());
            builder.ApplyConfiguration(new Unit2Config());

            base.OnModelCreating(builder);
        }
    }
}
