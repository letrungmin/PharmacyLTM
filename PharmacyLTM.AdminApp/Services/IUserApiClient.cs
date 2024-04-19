using PharmacyLTM.ViewModels.System.Users;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyLTM.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
