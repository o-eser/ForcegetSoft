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
    public class Unit1WriteRepository : WriteRepository<Unit1>, IUnit1WriteRepository
    {
        public Unit1WriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
