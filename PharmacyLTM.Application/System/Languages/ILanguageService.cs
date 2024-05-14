using PharmacyLTM.ViewModels.Common;
using PharmacyLTM.ViewModels.System.Languages;
using PharmacyLTM.ViewModels.System.Users;
using PharmacyLTM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyLTM.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}