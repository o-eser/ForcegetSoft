using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Enums;

namespace ForcegetSoft.Application.Models.DTOs
{
    public class UpdateOfferDTO
    {
        public Guid Id { get; set; }
        public Guid ModeId { get; set; }
        public Guid MovementTypeId { get; set; }
        public Guid IncotermId { get; set; }
        public Guid CityId { get; set; }
        public Guid CountryId { get; set; }
        public Guid Unit1Id { get; set; }
        public double Unit1Quantity { get; set; }
        public Guid Unit2Id { get; set; }
        public double Unit2Quantity { get; set; }
        public Currency Currency { get; set; }
        public Guid PackageTypeId { get; set; }
    }
}
