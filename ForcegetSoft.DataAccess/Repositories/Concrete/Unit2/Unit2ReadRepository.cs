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
    public class Unit2ReadRepository : ReadRepository<Unit2>, IUnit2ReadRepository
    {
        public Unit2ReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
