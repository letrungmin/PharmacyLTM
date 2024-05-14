using PharmacyLTM.Application.System.Roles;
using PharmacyLTM.Data.EF;
using PharmacyLTM.Data.Entities;
using PharmacyLTM.ViewModels.System.Roles;
using PharmacyLTM.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyLTM.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly PharmacyLTMDbContext _context;

        public SlideService(PharmacyLTMDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}