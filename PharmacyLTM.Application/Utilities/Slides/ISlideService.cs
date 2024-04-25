using PharmacyLTM.ViewModels.System.Roles;
using PharmacyLTM.ViewModels.Utilities.Slides;
using PharmacyLTM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyLTM.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}