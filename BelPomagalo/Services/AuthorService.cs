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
        /// <summary>
        /// Gets all Authors' names.
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<string> GetAllAuthorsNames()
        {
            return _context.Authors
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets an Author with the specified name.
        /// </summary>
        /// <param name="authorName"></param>
        /// <returns>Author</returns>
        internal Author GetAuthor(string authorName)
        {
            return _context.Authors
                .SingleOrDefault(x => x.Name == authorName);
        }
        /// <summary>
        /// Adds an Author.
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        internal async Task<Author> AddAuthor(Author author)
        {
            var addedAuthor = await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return addedAuthor.Entity;
        }
        /// <summary>
        /// Edits an author with the specified changes to apply.
        /// </summary>
        /// <param name="authorToEdit">Needs to be tracked by the db context.</param>
        /// <param name="changesToApply">The changes to apply to the author.</param>
        internal async void EditAuthor(Author authorToEdit, Author changesToApply)
        {
            authorToEdit.Name = changesToApply.Name;
            authorToEdit.Description = changesToApply.Description;
            authorToEdit.DiedDate = changesToApply.DiedDate;
            authorToEdit.BornDate = changesToApply.BornDate;
            authorToEdit.BornLocation = changesToApply.BornLocation;

            await _context.SaveChangesAsync();
        }

        internal bool Exists(string authorName)
        {
            return _context.Authors.SingleOrDefault(x => x.Name == authorName) != null;
        }
    }
}
