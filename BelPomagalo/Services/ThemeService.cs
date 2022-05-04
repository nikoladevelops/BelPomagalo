using BelPomagalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class ThemeService : Service
    {
        public ThemeService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all Themes' names.
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<string> GetAllThemesNames()
        {
            return _context.Themes
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets the Theme with this name.
        /// </summary>
        /// <param name="themeName">The Theme's name.</param>
        /// <returns></returns>
        internal Theme GetTheme(string themeName)
        {
            return _context.Themes
                .FirstOrDefault(x => x.Name == themeName);
        }
        /// <summary>
        /// Gtes the Theme with this id.
        /// </summary>
        /// <param name="themeId">The Theme's id.</param>
        /// <returns></returns>
        internal Theme GetTheme(int themeId)
        {
            return _context.Themes
                .FirstOrDefault(x => x.Id == themeId);
        }
        /// <summary>
        /// Add a Theme.
        /// </summary>
        /// <param name="theme">The Theme to add.</param>
        /// <returns></returns>
        internal async Task<Theme> AddTheme(Theme theme)
        {
             var addedTheme = await _context.Themes.AddAsync(theme);
             await _context.SaveChangesAsync();
             return addedTheme.Entity;
        }
        /// <summary>
        /// Check if a Theme with this name already exists.
        /// </summary>
        /// <param name="themeName">The Theme's name.</param>
        /// <returns></returns>
        internal bool Exists(string themeName)
        {
            return _context.Themes.SingleOrDefault(x => x.Name == themeName) != null;
        }
    }
}
