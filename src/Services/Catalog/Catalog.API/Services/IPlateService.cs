
namespace Catalog.API.Services
{
    public interface IPlateService
    {
        Task<List<Plate>> GetPlates();
    }
}