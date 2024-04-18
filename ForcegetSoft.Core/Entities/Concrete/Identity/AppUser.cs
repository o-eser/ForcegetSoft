using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;
using ForcegetSoft.Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace ForcegetSoft.Core.Entities.Concrete.Identity
{
    public class AppUser : IdentityUser<Guid>, IBaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; }  = Status.Active;
    }
}
