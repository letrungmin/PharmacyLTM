using PharmacyLTM.ViewModels.System.Users;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using PharmacyLTM.ViewModels.Common;

namespace PharmacyLTM.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<PageResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);
    }
}
