using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;
using ForcegetSoft.Core.Enums;

namespace ForcegetSoft.Core.Entities.Concrete
{
    public class BaseEntity : IBaseEntity, IEntity<Guid>
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; } = Status.Active;
        public Guid Id { get; set; }
    }
}
