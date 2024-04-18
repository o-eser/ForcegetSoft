using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.CountryService
{
    public class CountryService : ICountryService
    {
        private readonly IMapper _mapper;
        private readonly ICountryReadRepository _countryReadRepository;
        private readonly ICityReadRepository _cityReadRepository;

        public CountryService(IMapper mapper, ICountryReadRepository countryReadRepository, ICityReadRepository cityReadRepository)
        {
            _mapper = mapper;
            _countryReadRepository = countryReadRepository;
            _cityReadRepository = cityReadRepository;
        }

        public List<CountryVM> GetCountries()
        {
            var countries = from c in _countryReadRepository.Table
                            join ct in _cityReadRepository.Table on c.Id equals ct.CountryId
                            where c.Status != Status.Deleted && ct.Status != Status.Deleted
                            group ct by new { c.Id, c.Name } into cityGroup
                            select new CountryVM
                            {
                                Id = cityGroup.Key.Id,
                                Name = cityGroup.Key.Name,
                                Cities = _mapper.Map<List<CityVM>>(cityGroup.ToList())
                            };

            return countries.ToList();
        }
    }
}
