using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;

namespace ForcegetSoft.Core.Entities.Concrete
{
    public class Unit2 : BaseEntity
    {
        public Unit2()
        {
            Offers = new HashSet<Offer>();
        }
        public string Name { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
