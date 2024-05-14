using PharmacyLTM.ViewModels.Catalog.Categories;
using PharmacyLTM.ViewModels.Common;
using PharmacyLTM.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyLTM.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}