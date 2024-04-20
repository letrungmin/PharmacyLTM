using PharmacyLTM.ViewModels.Common;
using PharmacyLTM.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyLTM.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);

        Task<PageResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}