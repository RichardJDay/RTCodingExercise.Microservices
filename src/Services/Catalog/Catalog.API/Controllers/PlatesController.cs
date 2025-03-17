using Catalog.API.Services;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatesController : ControllerBase
    {
        private readonly IPlateService _plateService;

        public PlatesController(IPlateService plateService)
        {
            _plateService = plateService;
        }

        [HttpGet]
        public async Task<List<Plate>> GetPlates()
        {
            return await _plateService.GetPlates();
        }
    }
}
