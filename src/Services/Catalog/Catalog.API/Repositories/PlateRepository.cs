namespace Catalog.API.Repositories
{
    public class PlateRepository : IPlateRepository
    {
        private readonly ApplicationDbContext _context;

        public PlateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<Guid, Plate>> GetPlates()
        {
            return await _context.Plates.ToDictionaryAsync(x => x.Id, x => x);
        }
    }
}
