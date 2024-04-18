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
    public class IncotermReadRepository : ReadRepository<Incoterm>, IIncotermReadRepository
    {
        public IncotermReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
