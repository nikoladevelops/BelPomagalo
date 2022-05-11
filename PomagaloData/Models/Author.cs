namespace BelPomagalo.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? BornLocation { get; set; }
        public string? BornDate { get; set; }
        public string? DiedDate { get; set; }
        public string? Description { get; set; }
    }
}
