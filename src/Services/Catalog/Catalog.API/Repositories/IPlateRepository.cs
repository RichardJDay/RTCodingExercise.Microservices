
using Catalog.API.Controllers;

namespace Catalog.API.Repositories
{
    public interface IPlateRepository
    {
        Task<Plate> CreatePlate(Plate plate);
        Task<List<Plate>> GetPlates(int pageSize, int pageNumber);

    }
}