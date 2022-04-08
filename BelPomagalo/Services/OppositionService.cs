using BelPomagalo.Models;
namespace BelPomagalo.Services
{
    internal class OppositionService : Service
    {
        public OppositionService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<string> GetAllOppositionsNames()
        {
            return _context.Oppositions
                .Select(x => x.Name)
                .ToList();
        }
        internal Opposition GetOpposition(string oppositionName)
        {
            return _context.Oppositions
                .FirstOrDefault(x => x.Name == oppositionName);
        }
        internal Opposition GetOpposition(int oppositionId)
        {
            return _context.Oppositions
                .FirstOrDefault(x => x.Id == oppositionId);
        }
        internal async Task<Opposition> AddOpposition(Opposition opposition)
        {
            var addedOpposition = await _context.Oppositions.AddAsync(opposition);
            await _context.SaveChangesAsync();
            return addedOpposition.Entity;
        }
    }
}
