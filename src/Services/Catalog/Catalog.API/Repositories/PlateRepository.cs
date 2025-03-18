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

        public async Task<List<Plate>> GetPlates(GetPlateRequest getPlateRequest)
        {
            var thing =  await _context.Plates
                .Skip((getPlateRequest.PageNumber - 1) * getPlateRequest.PageSize)
                .Take(getPlateRequest.PageSize)
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
