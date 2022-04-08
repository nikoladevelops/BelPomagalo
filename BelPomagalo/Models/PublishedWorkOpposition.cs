using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Models
{
    internal class PublishedWorkOpposition
    {
        public int Id { get; set; }

        public int PublishedWorkId { get; set; }
        public PublishedWork PublishedWork { get; set; }

        public int OppositionId { get; set; }
        public Opposition Opposition { get; set; }
    }
}
