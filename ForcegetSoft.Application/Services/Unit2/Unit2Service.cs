using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.Unit2
{
    public class Unit2Service : IUnit2Service
    {
        private readonly IMapper _mapper;
        private readonly IUnit2ReadRepository _unit2ReadRepository;
        public Unit2Service(IMapper mapper, IUnit2ReadRepository unit2ReadRepository)
        {
            _mapper = mapper;
            _unit2ReadRepository = unit2ReadRepository;
        }

        public List<Unit2VM> GetUnit2s()
        {
            return _mapper.Map<List<Unit2VM>>(_unit2ReadRepository.GetWhere(x=>x.Status!=Status.Deleted,false));
        }
    }
}
