using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? BornLocation { get; set; }
        public string? BornDate { get; set; }
        public string? DiedDate { get; set; }
        public string? Description { get; set; }
    }
}
