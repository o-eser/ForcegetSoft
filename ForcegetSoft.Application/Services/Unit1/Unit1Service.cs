using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.Unit1
{
    public class Unit1Service : IUnit1Service
    {
        private readonly IMapper _mapper;
        private readonly IUnit1ReadRepository _unit1ReadRepository;
        public Unit1Service(IMapper mapper, IUnit1ReadRepository unit1ReadRepository)
        {
            _mapper = mapper;
            _unit1ReadRepository = unit1ReadRepository;
        }

        public List<Unit1VM> GetUnit1s()
        {
            return _mapper.Map<List<Unit1VM>>(_unit1ReadRepository.GetWhere(x=>x.Status!=Status.Deleted,false));
        }
    }
}
