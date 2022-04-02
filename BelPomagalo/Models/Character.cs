using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Models
{
    internal class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PublishedWork PublishedWork { get; set; }
        public int PublishedWorkId { get; set; }
        public string Description { get; set; }
    }
}
