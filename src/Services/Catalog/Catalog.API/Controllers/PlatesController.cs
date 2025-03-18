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
        public async Task<List<Plate>> GetPlates(int pageSize, int pageNumber)
        {
            var getPlateRequest = new GetPlateRequest
            {
                PageSize = pageSize,
                PageNumber = pageNumber
            };
            return await _plateService.GetPlates(getPlateRequest);
        }

        [HttpPost]
        public async Task<Plate> CreatePlate([FromBody] Plate plate)
        {
            var createdPlate = await _plateService.CreatePlate(plate);
            return createdPlate;
        }
    }
}
