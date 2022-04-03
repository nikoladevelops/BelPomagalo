using BelPomagalo.Models;
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
                .FirstOrDefault(x => x.Name == publishedWorkName);
        }
    }
}
