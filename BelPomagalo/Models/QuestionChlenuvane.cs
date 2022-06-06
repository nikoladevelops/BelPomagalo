namespace BelPomagalo.Models
{
    public class QuestionChlenuvane
    {
        public int Id { get; set; }
        public string Sentence { get; set; }
        public string CorrectSentence { get; set; }
        public string CorrectAnswers { get; set; }
        public string WrongAnswers { get; set; }
        public int CountAnswers { get; set; }
    }
}
