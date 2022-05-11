namespace BelPomagalo.Models
{
    public class PublishedWorkOpposition
    {
        public int Id { get; set; }

        public int PublishedWorkId { get; set; }
        public PublishedWork PublishedWork { get; set; }

        public int OppositionId { get; set; }
        public Opposition Opposition { get; set; }
    }
}
