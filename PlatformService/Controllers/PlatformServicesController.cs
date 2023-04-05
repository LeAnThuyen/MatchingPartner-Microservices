using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.DTO;
using PlatformService.Dtos;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformServicesController : ControllerBase
    {
        private readonly IPlatformRepo _platFormRepo;

        public PlatformServicesController(IPlatformRepo platFormRepo)
        {
            _platFormRepo = platFormRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<PlatformReadDto>> GetListAsync([FromQuery] PlatformGetListDto input)
        {
            return await _platFormRepo.GetAllPlatForm(input);
        }
        [HttpPost]
        public async Task<int> CreateAsync([FromBody] PlatFormCreateUpdateDto platFormCreateDto)
        {
            return await _platFormRepo.CreatePlatForm(platFormCreateDto);
        }
    }
}
