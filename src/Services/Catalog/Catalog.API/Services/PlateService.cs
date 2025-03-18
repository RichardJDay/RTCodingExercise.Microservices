using Catalog.API.Controllers;
using Catalog.API.Repositories;

namespace Catalog.API.Services
{
    public class PlateService : IPlateService
    {
        private readonly IPlateRepository _plateRepository;

        public PlateService(IPlateRepository plateRepository)
        {
            _plateRepository = plateRepository;
        }
        public async Task<List<Plate>> GetPlates(GetPlateRequest getPlateRequest)
        {
            var plates =  await _plateRepository.GetPlates(getPlateRequest);

            return plates;
        }

        public async Task<Plate> CreatePlate(Plate plate)
        {
            return await _plateRepository.CreatePlate(plate);
        }
    }
}
