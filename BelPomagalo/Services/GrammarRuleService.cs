using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class GrammarRuleService : Service
    {
        public GrammarRuleService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all GrammarRules' names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllGrammarRulesNames()
        {
            return _context.GrammarRules
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets the GrammarRule with this name.
        /// </summary>
        /// <param name="grammarRuleName">The GrammarRule's name.</param>
        /// <returns></returns>
        public GrammarRule GetGrammarRule(string grammarRuleName)
        {
            return _context.GrammarRules
                .FirstOrDefault(x => x.Name == grammarRuleName);
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
        /// <summary>
        /// Check if a GramamrRule with this name already exists.
        /// </summary>
        /// <param name="grammarRuleName">The GrammarRule's name.</param>
        /// <returns></returns>
        public bool Exists(string grammarRuleName)
        {
            return _context.GrammarRules.SingleOrDefault(x => x.Name == grammarRuleName) != null;
        }
        /// <summary>
        /// Edits a GrammarRule with the specified changes to apply.
        /// </summary>
        /// <param name="grammarRule">The GrammarRule you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the GrammarRule.</param>
        /// <returns></returns>
        public async Task EditGrammarRule(GrammarRule grammarRule, PunctuationRule changesToApply)
        {
            grammarRule.Name = changesToApply.Name;
            grammarRule.Description = changesToApply.Description;
            await _context.SaveChangesAsync();
        }
    }
}
