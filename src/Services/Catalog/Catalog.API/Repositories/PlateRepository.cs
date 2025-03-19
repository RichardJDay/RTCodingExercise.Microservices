using Catalog.API.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Repositories
{
    public class PlateRepository : IPlateRepository
    {
        private readonly ApplicationDbContext _context;

        public PlateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Plate>> GetPlates(int pageSize, int pageNumber)
        {
            var thing =  await _context.Plates
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return thing;
        }

        public async Task<Plate> CreatePlate(Plate plate)
        {
            _context.Plates.Add(plate);
            await _context.SaveChangesAsync();
            return plate;
        }
        
    }
}
