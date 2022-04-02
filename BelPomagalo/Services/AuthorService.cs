using BelPomagalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class AuthorService : Service
    {
        public AuthorService(ApplicationDbContext context) : base(context)
        {
        }

        internal IEnumerable<Author> GetAllAuthors() 
        {
            return _context.Authors.ToList();
        }
    }
}
