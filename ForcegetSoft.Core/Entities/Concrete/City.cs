using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;

namespace ForcegetSoft.Core.Entities.Concrete
{
    public class City : BaseEntity
    {
        public City()
        {
            Offers = new HashSet<Offer>();
        }
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
