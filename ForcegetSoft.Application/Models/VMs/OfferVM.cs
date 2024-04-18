using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Enums;

namespace ForcegetSoft.Application.Models.VMs
{
    public class OfferVM
    {
        public Guid Id { get; set; }
        public string ModeName { get; set; }
        public string MovementTypeName { get; set; }
        public string IncotermName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Unit1Name { get; set; }
        public double Unit1Quantity { get; set; }
        public string Unit2Name { get; set; }
        public double Unit2Quantity { get; set; }
        public Currency Currency { get; set; }
        public string PackageName { get; set; }
    }
}
