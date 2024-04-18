using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;
using ForcegetSoft.Core.Enums;

namespace ForcegetSoft.Core.Entities.Concrete
{
    public class Offer : BaseEntity
    {
        
        public double Unit1Quantity { get; set; }
        public double Unit2Quantity { get; set; }
        public Guid CityId { get; set; }
        public Guid IncotermId { get; set; }
        public Guid ModeId { get; set; }
        public Guid MovementTypeId { get; set; }
        public Guid PackageTypeId { get; set; }
        public Guid Unit1Id { get; set; }
        public Guid Unit2Id { get; set; }
        public Currency Currency { get; set; }
        public City City { get; set; }
        public Incoterm Incoterm { get; set; }
        public Mode Mode { get; set; }
        public MovementType MovementType { get; set; }
        public PackageType PackageType { get; set; }
        public Unit1 Unit1 { get; set; }
        public Unit2 Unit2 { get; set; }
    }
}
