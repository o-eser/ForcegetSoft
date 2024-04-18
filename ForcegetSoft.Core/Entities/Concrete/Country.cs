using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;

namespace ForcegetSoft.Core.Entities.Concrete
{
    public class Country : BaseEntity
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
