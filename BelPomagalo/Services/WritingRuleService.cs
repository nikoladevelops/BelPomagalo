using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class WritingRuleService : Service
    {
        public WritingRuleService(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds a WritingRule.
        /// </summary>
        /// <param name="writingRule">The WritingRule to add.</param>
        /// <returns></returns>
        public async Task<WritingRule> AddWritingRule(WritingRule writingRule)
        {
            var addedWritingRule = await _context.WritingRules.AddAsync(writingRule);
            await _context.SaveChangesAsync();
            return addedWritingRule.Entity;
        }
    }
}
