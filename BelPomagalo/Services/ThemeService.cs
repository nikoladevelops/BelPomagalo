using BelPomagalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    public class ThemeService : Service
    {
        public ThemeService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all Themes' names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllThemesNames()
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
        public Theme GetTheme(string themeName)
        {
            return _context.Themes
                .FirstOrDefault(x => x.Name == themeName);
        }
        /// <summary>
        /// Gtes the Theme with this id.
        /// </summary>
        /// <param name="themeId">The Theme's id.</param>
        /// <returns></returns>
        public Theme GetTheme(int themeId)
        {
            return _context.Themes
                .FirstOrDefault(x => x.Id == themeId);
        }
        /// <summary>
        /// Add a Theme.
        /// </summary>
        /// <param name="theme">The Theme to add.</param>
        /// <returns></returns>
        public async Task<Theme> AddTheme(Theme theme)
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
        public bool Exists(string themeName)
        {
            return _context.Themes.SingleOrDefault(x => x.Name == themeName) != null;
        }

        /// <summary>
        /// Edits a Theme with the specified changes to apply.
        /// </summary>
        /// <param name="theme">The Theme you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the Theme.</param>
        /// <returns></returns>
        public async Task EditTheme(Theme theme, Theme changesToApply)
        {
            theme.Name = changesToApply.Name;
            theme.Description = changesToApply.Description;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a theme.
        /// </summary>
        /// <param name="theme">The theme to delete.</param>
        public async void Delete(Theme theme)
        {
            _context.Themes.Remove(theme);
            await _context.SaveChangesAsync();
        }
    }
}
