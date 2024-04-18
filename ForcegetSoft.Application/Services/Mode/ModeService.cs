using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForcegetSoft.Application.Models.VMs;
using ForcegetSoft.DataAccess.Repositories.Abstract;

namespace ForcegetSoft.Application.Services.Mode
{
    public class ModeService : IModeService
    {
        private readonly IMapper _mapper;
        private readonly IModeReadRepository _modeReadRepository;

        public ModeService(IMapper mapper, IModeReadRepository modeReadRepository)
        {
            _mapper = mapper;
            _modeReadRepository = modeReadRepository;
        }
        public List<ModeVM> GetModes()
        {
            return _mapper.Map<List<ModeVM>>(_modeReadRepository.GetWhere(m => m.Status != Core.Enums.Status.Deleted,false).ToList());
        }
    }
}
