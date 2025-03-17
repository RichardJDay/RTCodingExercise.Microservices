
namespace Catalog.API.Repositories
{
    public interface IPlateRepository
    {
        Task<Dictionary<Guid, Plate>> GetPlates();
    }
}