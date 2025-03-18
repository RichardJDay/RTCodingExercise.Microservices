
using Catalog.API.Controllers;
using Catalog.Domain;

namespace Catalog.API.Services
{
    public interface IPlateService
    {
        Task<Plate> CreatePlate(Plate plate);
        Task<List<Plate>> GetPlates(GetPlateRequest getPlateRequest);
    }
}