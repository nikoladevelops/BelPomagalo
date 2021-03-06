namespace BelPomagalo.Models
{
    public class PublishedWork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PublishedDate { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public string? CompositionDetails { get; set; }
        public string? MotivesAndFigures { get; set; }
        public string? IdeologicalSuggestions { get; set; }
        public string? Remarks { get; set; }
    }
}
