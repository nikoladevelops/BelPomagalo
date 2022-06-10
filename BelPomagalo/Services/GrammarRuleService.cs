using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class GrammarRuleService : Service
    {
        public GrammarRuleService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Adds a GrammarRule.
        /// </summary>
        /// <param name="grammarRule">The GrammarRule to add.</param>
        /// <returns></returns>
        public async Task<GrammarRule> AddGrammarRule(GrammarRule grammarRule)
        {
            var addedGrammarRule = await _context.GrammarRules.AddAsync(grammarRule);
            await _context.SaveChangesAsync();
            return addedGrammarRule.Entity;
        }
    }
}
