using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Application.Models.VMs;

namespace ForcegetSoft.Application.Services.MovementType
{
    public interface IMovementTypeService
    {
        List<MovementTypeVM> GetMovementTypes();
    }
}
