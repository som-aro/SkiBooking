using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkiBooking.Api.Dto;
using SkiBooking.Entities;
using SkiBooking.Interface;
using System.Net;

namespace SkiBooking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkiPackageController : ControllerBase
    {
        private readonly ILogger<SkiPackageController> _logger;
        private readonly ISkiPackageService _skiPackageService;
        private readonly IMapper _mapper;
        public SkiPackageController(ILogger<SkiPackageController> logger, ISkiPackageService skiPackageService, IMapper mapper)
        {
            _logger = logger;
            _skiPackageService = skiPackageService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("SkiPackages")]
        public async Task<IActionResult> GetSkiPackages()
        {
            var skiPackages = _skiPackageService.GetAllPackages();
            var dto = _mapper.Map<IEnumerable<SkiPackage>, IEnumerable<SkiPackageSummaryDto>>(skiPackages);
            return Ok(dto);
        }


        [HttpGet]
        [Route("SkiPackages/{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var package = _skiPackageService.GetPackage(id);
            if (package == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<SkiPackage, SkiPackageDto>(package));
        }
    }
}
