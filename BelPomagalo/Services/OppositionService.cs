using BelPomagalo.Models;
namespace BelPomagalo.Services
{
    internal class OppositionService : Service
    {
        public OppositionService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all Oppositions' names.
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<string> GetAllOppositionsNames()
        {
            return _context.Oppositions
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets the Opposition with this name.
        /// </summary>
        /// <param name="oppositionName">The Opposition's name.</param>
        /// <returns></returns>
        internal Opposition GetOpposition(string oppositionName)
        {
            return _context.Oppositions
                .SingleOrDefault(x => x.Name == oppositionName);
        }
        /// <summary>
        /// Gets the Opposition with this id.
        /// </summary>
        /// <param name="oppositionId">The Opposition's id.</param>
        /// <returns></returns>
        internal Opposition GetOpposition(int oppositionId)
        {
            return _context.Oppositions
                .SingleOrDefault(x => x.Id == oppositionId);
        }
        /// <summary>
        /// Adds an Opposition.
        /// </summary>
        /// <param name="opposition">The Opposition to add.</param>
        /// <returns></returns>
        internal async Task<Opposition> AddOpposition(Opposition opposition)
        {
            var addedOpposition = await _context.Oppositions.AddAsync(opposition);
            await _context.SaveChangesAsync();
            return addedOpposition.Entity;
        }
        /// <summary>
        /// Checks if an Opposition with this name already exists.
        /// </summary>
        /// <param name="oppositionName">The Opposition's name.</param>
        /// <returns></returns>
        internal bool Exists(string oppositionName)
        {
            return _context.Oppositions.SingleOrDefault(x => x.Name == oppositionName) != null;
        }

        /// <summary>
        /// Edits an Opposition with the specified changes to apply.
        /// </summary>
        /// <param name="opposition">The Opposition you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the Opposition.</param>
        /// <returns></returns>
        internal async Task EditOpposition(Opposition opposition, Opposition changesToApply)
        {
            opposition.Name = changesToApply.Name;
            opposition.Description = changesToApply.Description;
            await _context.SaveChangesAsync();
        }
    }
}
