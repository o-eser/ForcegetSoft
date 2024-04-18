using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.PackageType
{
    public class PackageTypeService : IPackageTypeService
    {
        private readonly IMapper _mapper;
        private readonly IPackageTypeReadRepository _packageTypeReadRepository;
        public PackageTypeService(IMapper mapper, IPackageTypeReadRepository packageTypeReadRepository)
        {
            _mapper = mapper;
            _packageTypeReadRepository = packageTypeReadRepository;
        }

        public List<PackageTypeVM> GetPackageTypes()
        {
            return _mapper.Map<List<PackageTypeVM>>(_packageTypeReadRepository.GetWhere(x=>x.Status!=Status.Deleted,false).ToList());
        }
    }
}
