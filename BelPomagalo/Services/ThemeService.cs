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

        internal IEnumerable<string> GetAllThemesNames()
        {
            return _context.Themes
                .Select(x => x.Name)
                .ToList();
        }
    }
}
