using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Application.Models.DTOs;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Entities.Concrete;

namespace ForcegetSoft.Application.Services
{
    public interface IOfferService
    {
        Task Create(CreateOfferDTO model);
        Task Update(UpdateOfferDTO model);
        Task Delete(string id);
        Task<OfferVM> GetById(string id);
        Task<UpdateOfferDTO> GetCreateOffer(string id);
        List<OfferVM> GetOffers();
    }
}
