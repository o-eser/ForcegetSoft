using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Application.Models.VMs;

namespace ForcegetSoft.Application.Services.Unit2
{
    public interface IUnit2Service
    {
        List<Unit2VM> GetUnit2s();
    }
}
