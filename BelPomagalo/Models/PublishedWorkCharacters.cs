using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Models
{
    internal class PublishedWorkCharacters
    {
        public int Id { get; set; }

        public PublishedWork PublishedWork { get; set; }
        public int PublishedWorkId { get; set; }

        public Character Character { get; set; }
        public int CharacterId { get; set; }
    }
}
