using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;

namespace ForcegetSoft.Core.Entities.Concrete
{
    public class Mode : BaseEntity
    {
        public Mode()
        {
            Offers = new HashSet<Offer>();
        }
        public string Name { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
