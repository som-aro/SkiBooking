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
    public class EquipmentController : ControllerBase
    {
        private readonly ILogger<EquipmentController> _logger;
        private readonly IEquipmentService _equipmentService;
        private readonly IMapper _mapper;
        public EquipmentController(ILogger<EquipmentController> logger, IEquipmentService equipmentService, IMapper mapper)
        {
            _logger = logger;
            _equipmentService = equipmentService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("EquipmentTypes")]
        public async Task<IActionResult> GetEquipmentTypes()
        {
            var equipments = _equipmentService.GetEquipmentTypes();
            var dto = _mapper.Map<IEnumerable<EquipmentType>, IEnumerable<EquipmentTypeDto>>(equipments);
            return Ok(dto);
        }
    }
}