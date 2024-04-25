using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacyLTM.Application.System.Roles;
using PharmacyLTM.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PharmacyLTM.Application.Utilities.Slides;

namespace PharmacyLTM.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolesController : ControllerBase
    {
        private readonly ISlideService _roleService;

        public RolesController(ISlideService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleService.GetAll();
            return Ok(roles);
        }
    }
}