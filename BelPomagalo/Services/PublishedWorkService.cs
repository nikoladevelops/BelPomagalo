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

        internal IEnumerable<PublishedWork> GetAllPublishedWorks()
        {
            return _context.PublishedWorks.ToList();
        }

        internal IEnumerable<PublishedWork> GetPublishedWorksOfAuthor(int authorId)
        {
            return _context.PublishedWorks
                .Where(x=>x.AuthorId==authorId)
                .ToList();
        }
    }
}
