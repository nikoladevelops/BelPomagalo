using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class QuestionChlenuvaneService : Service
    {
        public QuestionChlenuvaneService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all QuestionChlenuvane sentences.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllQuestionChlenuvaneSentences()
        {
            return _context.QuestionsChlenuvane
                .Select(x => x.Sentence)
                .ToList();
        }
        /// <summary>
        /// Gets the QuestionChlenuvane that has this sentence.
        /// </summary>
        /// <param name="questionChlenuvaneSentence">The QuestionChlenuvane's sentence.</param>
        /// <returns></returns>
        public QuestionChlenuvane GetQuestionChlenuvane(string questionChlenuvaneSentence)
        {
            return _context.QuestionsChlenuvane
                .FirstOrDefault(x => x.Sentence == questionChlenuvaneSentence);
        }
        /// <summary>
        /// Adds a QuestionChlenuvane.
        /// </summary>
        /// <param name="questionChlenuvane">The QuestionChlenuvane to add.</param>
        /// <returns></returns>
        public async Task<QuestionChlenuvane> AddQuestionChlenuvane(QuestionChlenuvane questionChlenuvane)
        {
            var addedQuestion = await _context.QuestionsChlenuvane.AddAsync(questionChlenuvane);
            await _context.SaveChangesAsync();
            return addedQuestion.Entity;
        }
        /// <summary>
        /// Check if a QuestionChlenuvane with this sentence already exists.
        /// </summary>
        /// <param name="questionChlenuvaneSentence">The QuestionChlenuvane's sentence.</param>
        /// <returns></returns>
        public bool Exists(string questionChlenuvaneSentence)
        {
            return _context.QuestionsChlenuvane.SingleOrDefault(x => x.Sentence == questionChlenuvaneSentence) != null;
        }
        /// <summary>
        /// Edits a QuestionChlenuvane with the specified changes to apply.
        /// </summary>
        /// <param name="questionChlenuvane">The QuestionChlenuvane you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the QuestionChlenuvane.</param>
        /// <returns></returns>
        public async Task EditQuestionChlenuvane(QuestionChlenuvane questionChlenuvane, QuestionChlenuvane changesToApply)
        {
            questionChlenuvane.Sentence = changesToApply.Sentence;
            questionChlenuvane.CorrectSentence = changesToApply.CorrectSentence;
            questionChlenuvane.WrongAnswers = changesToApply.WrongAnswers;
            questionChlenuvane.CorrectAnswers = changesToApply.CorrectAnswers;
            questionChlenuvane.CountAnswers = changesToApply.CountAnswers;
            await _context.SaveChangesAsync();
        }
    }
}
