namespace BelPomagalo.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
