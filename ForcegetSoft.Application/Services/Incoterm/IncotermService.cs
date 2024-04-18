using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.Core.Enums;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.Incoterm
{
    public class IncotermService : IIncotermService
    {
        private readonly IMapper _mapper;
        private readonly IIncotermReadRepository _incotermReadRepository;

        public IncotermService(IIncotermReadRepository incotermReadRepository, IMapper mapper)
        {
            _incotermReadRepository = incotermReadRepository;
            _mapper = mapper;
        }

        public List<IncotermVM> GetIncoterms()
        {
            return _mapper.Map<List<IncotermVM>>(_incotermReadRepository.GetWhere(i => i.Status != Status.Deleted,false).ToList());
        }
    }
}
