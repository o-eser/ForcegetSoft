using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Concrete.Identity;
using ForcegetSoft.DataAccess.Persistence;
using ForcegetSoft.DataAccess.Repositories.Abstract;
using ForcegetSoft.DataAccess.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ForcegetSoft.DataAccess
{
    public static class DataAccessRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySQL(
                    configuration.GetConnectionString(AppDbContext.ConnectionName),
                    options => options.EnableRetryOnFailure(
                        10,
                        TimeSpan.FromSeconds(10),
                        null));
            });

            services.AddIdentity<AppUser,AppRole>(opt =>
            {
                opt.SignIn.RequireConfirmedEmail = false;
                opt.SignIn.RequireConfirmedPhoneNumber = false;
                opt.SignIn.RequireConfirmedAccount = false;
                opt.User.RequireUniqueEmail = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 3;
                opt.Password.RequireLowercase = false;


            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.AddScoped<ICityReadRepository, CityReadRepository>();
            services.AddScoped<ICityWriteRepository, CityWriteRepository>();

            services.AddScoped<ICountryReadRepository, CountryReadRepository>();
            services.AddScoped<ICountryWriteRepository, CountryWriteRepository>();

            services.AddScoped<IIncotermReadRepository, IncotermReadRepository>();
            services.AddScoped<IIncotermWriteRepository, IncotermWriteRepository>();

            services.AddScoped<IModeReadRepository, ModeReadRepository>();
            services.AddScoped<IModeWriteRepository, ModeWriteRepository>();

            services.AddScoped<IMovementTypeReadRepository, MovementTypeReadRepository>();
            services.AddScoped<IMovementTypeWriteRepository, MovementTypeWriteRepository>();

            services.AddScoped<IOfferReadRepository, OfferReadRepository>();
            services.AddScoped<IOfferWriteRepository, OfferWriteRepository>();

            services.AddScoped<IPackageTypeReadRepository, PackageTypeReadRepository>();
            services.AddScoped<IPackageTypeWriteRepository, PackageTypeWriteRepository>();

            services.AddScoped<IUnit1ReadRepository, Unit1ReadRepository>();
            services.AddScoped<IUnit1WriteRepository, Unit1WriteRepository>();

            services.AddScoped<IUnit2ReadRepository, Unit2ReadRepository>();
            services.AddScoped<IUnit2WriteRepository, Unit2WriteRepository>();


            return services;
        }
    }
}
