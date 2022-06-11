using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class PunctuationRuleService : Service
    {
        public PunctuationRuleService(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds a PunctuationRule.
        /// </summary>
        /// <param name="punctuationRule">The PunctuationRule to add.</param>
        /// <returns></returns>
        public async Task<PunctuationRule> AddPunctuationRule(PunctuationRule punctuationRule)
        {
            var addedPunctuationRule = await _context.PunctuationRules.AddAsync(punctuationRule);
            await _context.SaveChangesAsync();
            return addedPunctuationRule.Entity;
        }
    }
}
