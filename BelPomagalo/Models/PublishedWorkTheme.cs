using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Models
{
    internal class PublishedWorkTheme
    {
        public int Id { get; set; }

        public int ThemeId { get; set; }
        public Theme Theme { get; set; }

        public int PublishedWorkId { get; set; }
        public PublishedWork PublishedWork { get; set; }
    }
}
