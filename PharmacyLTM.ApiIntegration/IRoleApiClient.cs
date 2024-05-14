using PharmacyLTM.ViewModels.Catalog.Categories;
using PharmacyLTM.ViewModels.Common;
using PharmacyLTM.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyLTM.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
        Task<RoleVm> GetById(string languageId, Guid id);
    }
}