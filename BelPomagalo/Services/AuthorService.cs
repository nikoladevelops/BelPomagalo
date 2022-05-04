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
        /// <returns></returns>
        internal Author GetAuthor(string authorName)
        {
            return _context.Authors
                .SingleOrDefault(x => x.Name == authorName);
        }
        /// <summary>
        /// Adds an Author.
        /// </summary>
        /// <param name="author">The Author to add.</param>
        /// <returns></returns>
        internal async Task<Author> AddAuthor(Author author)
        {
            var addedAuthor = await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return addedAuthor.Entity;
        }
        /// <summary>
        /// Edits an Author with the specified changes to apply.
        /// </summary>
        /// <param name="authorToEdit">The Author to edit. Needs to be tracked by the db context.</param>
        /// <param name="changesToApply">The changes to apply to the Author.</param>
        internal async void EditAuthor(Author authorToEdit, Author changesToApply)
        {
            authorToEdit.Name = changesToApply.Name;
            authorToEdit.Description = changesToApply.Description;
            authorToEdit.DiedDate = changesToApply.DiedDate;
            authorToEdit.BornDate = changesToApply.BornDate;
            authorToEdit.BornLocation = changesToApply.BornLocation;

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Checks if an Author that has this name already exists.
        /// </summary>
        /// <param name="authorName">The name that the Author has.</param>
        /// <returns></returns>
        internal bool Exists(string authorName)
        {
            return _context.Authors.SingleOrDefault(x => x.Name == authorName) != null;
        }
    }
}
