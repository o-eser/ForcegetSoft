using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.CityService
{
    public class CityService : ICityService
    {
        private readonly ICityReadRepository _cityReadRepository;
        private readonly ICountryReadRepository _countryReadRepository;
        private readonly IMapper _mapper;

        public CityService(ICityReadRepository cityReadRepository, IMapper mapper, ICountryReadRepository countryReadRepository)
        {
            _cityReadRepository = cityReadRepository;
            _mapper = mapper;
            _countryReadRepository = countryReadRepository;
        }

        public IEnumerable<CityVM> GetAllCities()
        {
            var cities = from ct in _cityReadRepository.Table
                         join c in _countryReadRepository.Table on ct.CountryId equals c.Id
                         where c.Status != Status.Deleted && ct.Status != Status.Deleted
                         select new CityVM
                         {
                             Id = ct.Id,
                             Name = ct.Name,
                             CountryId = ct.CountryId,
                             CountryName = ct.Country.Name
                         };
            return cities.ToList();
        }

        public async Task<CityVM> GetCityByIdAsync(string id)
        {
            return _mapper.Map<CityVM>(await _cityReadRepository.GetByIdAsync(id));
        }
    }
}
