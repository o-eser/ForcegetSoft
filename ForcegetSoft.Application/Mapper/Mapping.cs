using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.DTOs;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Entities.Concrete;

namespace ForcegetSoft.Application.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<City, CityVM>().ReverseMap();
            CreateMap<Country, CountryVM>().ReverseMap();
            CreateMap<Incoterm, IncotermVM>().ReverseMap();
            CreateMap<Mode, ModeVM>().ReverseMap();
            CreateMap<Incoterm,IncotermVM>().ReverseMap();
            CreateMap<MovementType,MovementTypeVM>().ReverseMap();
            CreateMap<PackageType,PackageTypeVM>().ReverseMap();
            CreateMap<Unit1,Unit1VM>().ReverseMap();
            CreateMap<Unit2,Unit2VM>().ReverseMap();
            CreateMap<Offer,OfferVM>().ReverseMap();
            CreateMap<Offer,CreateOfferDTO>().ReverseMap();
            CreateMap<Offer,UpdateOfferDTO>().ReverseMap();
        }
    }
}
