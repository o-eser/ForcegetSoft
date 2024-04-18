using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Application.Models.DTOs;
using Microsoft.AspNetCore.Identity;

namespace ForcegetSoft.Application.Services
{
    public interface IAppUserService
    {
        Task<IdentityResult> Register(RegisterDTO model);
        Task<SignInResult> Login(LoginDTO model);
        // Todo : Implement the following methods
        //Task<UpdateProfileDTO> GetByUserName(string userName);
        //Task UpdateProfile(UpdateProfileDTO model);
        Task Logout();
    }
}
