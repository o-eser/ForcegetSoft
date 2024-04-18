using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Concrete;
using ForcegetSoft.DataAccess.Persistence;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.DataAccess.Repositories.Concrete
{
    public class OfferWriteRepository : WriteRepository<Offer>, IOfferWriteRepository
    {
        public OfferWriteRepository(AppDbContext context) : base(context) { }
    }
}
