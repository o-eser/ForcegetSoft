using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.MovementType
{
    public class MovementTypeService : IMovementTypeService
    {
        private readonly IMapper _mapper;
        private readonly IMovementTypeReadRepository _movementTypeReadRepository;
        public MovementTypeService(IMapper mapper, IMovementTypeReadRepository movementTypeReadRepository)
        {
            _mapper = mapper;
            _movementTypeReadRepository = movementTypeReadRepository;
        }

        public List<MovementTypeVM> GetMovementTypes()
        {
            return _mapper.Map<List<MovementTypeVM>>(_movementTypeReadRepository.GetWhere(x=>x.Status!=Status.Deleted,false).ToList());
        }
    }
}
