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
        internal IEnumerable<string> GetPublishedWorksNames(int authorId)
        {
            return _context.PublishedWorks
                .Where(x => x.AuthorId == authorId)
                .Select(x => x.Name)
                .ToList();
        }
        internal PublishedWork GetPublishedWork(string publishedWorkName)
        {
            return _context.PublishedWorks
                .Include(x=>x.Theme)
                .Include(x=>x.Genre)
                .Include(x=>x.Author)
                .FirstOrDefault(x => x.Name == publishedWorkName);
        }
    }
}
