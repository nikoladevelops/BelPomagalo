using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class QuestionChlenuvaneService : Service
    {
        public QuestionChlenuvaneService(ApplicationDbContext context) : base(context)
        {
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
    }
}
