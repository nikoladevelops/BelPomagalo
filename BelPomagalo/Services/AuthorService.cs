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
        internal IEnumerable<string> GetAllAuthorsNames()
        {
            return _context.Authors
                .Select(x => x.Name)
                .ToList();
        }
        internal Author GetAuthor(string authorName)
        {
            return _context.Authors
                .FirstOrDefault(x => x.Name == authorName);
        }
        internal async Task<Author> AddAuthor(Author author)
        {
            var addedAuthor = await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return addedAuthor.Entity;
        }
    }
}
