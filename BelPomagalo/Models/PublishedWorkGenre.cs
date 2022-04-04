using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Models
{
    internal class PublishedWorkGenre
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int PublishedWorkId { get; set; }
        public PublishedWork PublishedWork { get; set; }
    }
}
