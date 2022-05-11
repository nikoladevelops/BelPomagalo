namespace BelPomagalo.Models
{
    public class PublishedWorkCharacter
    {
        public int Id { get; set; }

        public PublishedWork PublishedWork { get; set; }
        public int PublishedWorkId { get; set; }

        public Character Character { get; set; }
        public int CharacterId { get; set; }
    }
}
