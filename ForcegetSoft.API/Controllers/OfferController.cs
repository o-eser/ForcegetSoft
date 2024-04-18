using ForcegetSoft.Application.Models.DTOs;
using ForcegetSoft.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForcegetSoft.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_offerService.GetOffers());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_offerService.GetById(id));
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetCreateOffer(string id)
        {
            return Ok(await _offerService.GetCreateOffer(id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOfferDTO model)
        {
            try
            {
                await _offerService.Create(model);
                return Ok();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(""+ex);
            }
            
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateOfferDTO model)
        {
            try
            {
                await _offerService.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(""+ex);
            }
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await _offerService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(""+ex);
            }
        }
    }
}
