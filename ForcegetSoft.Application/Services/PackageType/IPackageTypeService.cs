using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Application.Models.VMs;

namespace ForcegetSoft.Application.Services.PackageType
{
    public interface IPackageTypeService
    {
        List<PackageTypeVM> GetPackageTypes();
    }
}
