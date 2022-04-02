using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal abstract class Service
    {
        protected readonly ApplicationDbContext _context;
        protected Service(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
