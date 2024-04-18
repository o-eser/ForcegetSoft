using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Castle.Core.Configuration;
using ForcegetSoft.Application.Mapper;
using ForcegetSoft.Application.Services;
using ForcegetSoft.Application.Services.CityService;
using ForcegetSoft.Application.Services.CountryService;
using ForcegetSoft.Application.Services.Incoterm;
using ForcegetSoft.Application.Services.Mode;
using ForcegetSoft.Application.Services.MovementType;
using ForcegetSoft.Application.Services.PackageType;
using ForcegetSoft.Application.Services.Unit1;
using ForcegetSoft.Application.Services.Unit2;
using ForcegetSoft.Core.Entities.Concrete.Identity;
using ForcegetSoft.DataAccess.Persistence;
using ForcegetSoft.DataAccess.Repositories.Abstract;
using ForcegetSoft.DataAccess.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ForcegetSoft.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IIncotermService, IncotermService>();
            services.AddScoped<IModeService, ModeService>();
            services.AddScoped<IMovementTypeService, MovementTypeService>();
            services.AddScoped<IPackageTypeService, PackageTypeService>();
            services.AddScoped<IUnit1Service, Unit1Service>();
            services.AddScoped<IUnit2Service, Unit2Service>();
            services.AddScoped<IOfferService, OfferService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
