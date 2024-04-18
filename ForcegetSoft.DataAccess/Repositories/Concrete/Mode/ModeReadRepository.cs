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
    public class ModeReadRepository : ReadRepository<Mode>, IModeReadRepository
    {
        public ModeReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
