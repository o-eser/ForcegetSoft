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
    public class MovementTypeReadRepository : ReadRepository<MovementType>, IMovementTypeReadRepository
    {
        public MovementTypeReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
