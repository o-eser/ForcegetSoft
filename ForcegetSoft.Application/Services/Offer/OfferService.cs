using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.DTOs;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Entities.Concrete;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services
{
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IOfferReadRepository _offerReadRepository;
        private readonly IOfferWriteRepository _offerWriteRepository;
        private readonly IIncotermReadRepository _incotermReadRepository;
        private readonly ICityReadRepository _cityReadRepository;
        private readonly ICountryReadRepository _countryReadRepository;
        private readonly IModeReadRepository _modeReadRepository;
        private readonly IMovementTypeReadRepository _movementTypeReadRepository;
        private readonly IPackageTypeReadRepository _packageTypeReadRepository;
        private readonly IUnit1ReadRepository _unit1ReadRepository;
        private readonly IUnit2ReadRepository _unit2ReadRepository;

        public OfferService(IMapper mapper, IOfferReadRepository offerReadRepository, IOfferWriteRepository offerWriteRepository, IIncotermReadRepository incotermReadRepository, ICityReadRepository cityReadRepository, IModeReadRepository modeReadRepository, ICountryReadRepository countryReadRepository, IMovementTypeReadRepository movementTypeReadRepository, IPackageTypeReadRepository packageTypeReadRepository, IUnit1ReadRepository unit1ReadRepository, IUnit2ReadRepository unit2ReadRepository)
        {
            _mapper = mapper;
            _offerReadRepository = offerReadRepository;
            _offerWriteRepository = offerWriteRepository;
            _incotermReadRepository = incotermReadRepository;
            _cityReadRepository = cityReadRepository;
            _modeReadRepository = modeReadRepository;
            _countryReadRepository = countryReadRepository;
            _movementTypeReadRepository = movementTypeReadRepository;
            _packageTypeReadRepository = packageTypeReadRepository;
            _unit1ReadRepository = unit1ReadRepository;
            _unit2ReadRepository = unit2ReadRepository;
        }

        public async Task Create(CreateOfferDTO model)
        {
            try
            {
                await _offerWriteRepository.AddAsync(_mapper.Map<Offer>(model));
                await _offerWriteRepository.SaveAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(""+ex);
            }
        }

        public async Task Delete(string id)
        {
            try
            {
                await _offerWriteRepository.RemoveAsync(id);
                await _offerWriteRepository.SaveAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("" + ex);
            }
        }

        public async Task<OfferVM> GetById(string id)
        {
            var offers = GetOffers();
            var offer = offers.FirstOrDefault(x => x.Id.ToString() == id);
            if (offer == null)
                throw new ArgumentException("Offer not found");
            else
                return offer;
        }

        public async Task<UpdateOfferDTO> GetCreateOffer(string id)
        {
            var offer =await _offerReadRepository.GetByIdAsync(id);
            var dto = _mapper.Map<UpdateOfferDTO>(offer);
            var city = await _cityReadRepository.GetByIdAsync(offer.CityId.ToString());
            dto.CountryId = city.CountryId;
            return dto;
        }

        public List<OfferVM> GetOffers()
        {
            var offers= from offer in _offerReadRepository.Table
                        join city in _cityReadRepository.Table on offer.CityId equals city.Id
                        join country in _countryReadRepository.Table on city.CountryId equals country.Id
                        join incoterm in _incotermReadRepository.Table on offer.IncotermId equals incoterm.Id
                        join mode in _modeReadRepository.Table on offer.ModeId equals mode.Id
                        join movementType in _movementTypeReadRepository.Table on offer.MovementTypeId equals movementType.Id
                        join packageType in _packageTypeReadRepository.Table on offer.PackageTypeId equals packageType.Id
                        join unit1 in _unit1ReadRepository.Table on offer.Unit1Id equals unit1.Id
                        join unit2 in _unit2ReadRepository.Table on offer.Unit2Id equals unit2.Id
                        where offer.Status!= Status.Deleted && city.Status != Status.Deleted && country.Status != Status.Deleted && incoterm.Status != Status.Deleted && mode.Status != Status.Deleted && movementType.Status != Status.Deleted && packageType.Status != Status.Deleted && unit1.Status != Status.Deleted && unit2.Status != Status.Deleted
                        select new OfferVM
                        {
                            Id = offer.Id,
                            Unit1Quantity = offer.Unit1Quantity,
                            Unit2Quantity = offer.Unit2Quantity,
                            CityName = city.Name,
                            CountryName = country.Name,
                            IncotermName = incoterm.Name,
                            ModeName = mode.Name,
                            MovementTypeName = movementType.Name,
                            PackageName = packageType.Name,
                            Unit1Name = unit1.Name,
                            Unit2Name = unit2.Name,
                            Currency = offer.Currency
                        };

            return offers.ToList();
        }

        public async Task Update(UpdateOfferDTO model)
        {
            try
            {
                _offerWriteRepository.Update(_mapper.Map<Offer>(model));
                await _offerWriteRepository.SaveAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("" + ex);
            }
        }
    }
}
