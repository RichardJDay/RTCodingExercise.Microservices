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
        public async Task<List<Plate>> GetPlates()
        {
            var plates =  await _plateRepository.GetPlates();

            return plates.Values.ToList();
        }
    }
}
