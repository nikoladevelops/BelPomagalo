using BelPomagalo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class PublishedWorkService : Service
    {
        public PublishedWorkService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all PublishedWorks' names of an Author that has this id.
        /// </summary>
        /// <param name="authorId">The Author id, whose PublishedWorks' names you need.</param>
        /// <returns></returns>
        internal IEnumerable<string> GetPublishedWorksNames(int authorId)
        {
            return _context.PublishedWorks
                .Where(x => x.AuthorId == authorId)
                .Select(x => x.Name)
                .ToList();
        }

        /// <summary>
        /// Gets a PublishedWork of an Author.
        /// </summary>
        /// <param name="publishedWorkName">The PublishedWork's name.</param>
        /// <param name="authorThatOwnsPublishedWork">The Author that owns the PublishedWork.</param>
        /// <returns></returns>
        internal PublishedWork GetPublishedWork(string publishedWorkName, Author authorThatOwnsPublishedWork)
        {
            return _context.PublishedWorks
                .SingleOrDefault(x => x.Name == publishedWorkName && x.AuthorId == authorThatOwnsPublishedWork.Id);
        }
        /// <summary>
        /// Adds a PublishedWork.
        /// </summary>
        /// <param name="publishedWork">The PublishedWork to add.</param>
        /// <returns></returns>
        internal async Task<PublishedWork> AddPublishedWork(PublishedWork publishedWork)
        {
            var result = await _context.PublishedWorks.AddAsync(publishedWork);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        /// <summary>
        /// Checks if a PublishedWork with this name is already owned by this Author.
        /// </summary>
        /// <param name="publishedWorkName">The PublishedWork's name.</param>
        /// <param name="authorThatOwnsPublishedWork">The Author that may or may not own the PublishedWork.</param>
        /// <returns></returns>
        internal bool IsOwnedByAuthor(string publishedWorkName, Author authorThatOwnsPublishedWork)
        {
            var publishedWork = GetPublishedWork(publishedWorkName, authorThatOwnsPublishedWork);
            if (publishedWork != null && publishedWork.AuthorId == authorThatOwnsPublishedWork.Id)
            {
                return true;
            }
            return false;
        }
    }
}
