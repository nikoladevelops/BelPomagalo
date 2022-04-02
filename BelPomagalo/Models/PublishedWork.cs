using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Models
{
    internal class PublishedWork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishedDate { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public string CompositionDetails { get; set; }

        public Theme Theme { get; set; }
        public int ThemeId { get; set; }
    }
}
