﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Enums;

namespace ForcegetSoft.Application.Models.DTOs
{
    public class RegisterDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate => DateTime.Now;
        public Status Status => Status.Active;
    }
}
