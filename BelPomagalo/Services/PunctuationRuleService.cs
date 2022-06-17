using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class PunctuationRuleService : Service
    {
        public PunctuationRuleService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all PunctuationRules' names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllPunctuationRulesNames()
        {
            return _context.PunctuationRules
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets the PunctuationRule with this name.
        /// </summary>
        /// <param name="punctuationRuleName">The PunctuationRule's name.</param>
        /// <returns></returns>
        public PunctuationRule GetPunctuationRule(string punctuationRuleName)
        {
            return _context.PunctuationRules
                .FirstOrDefault(x => x.Name == punctuationRuleName);
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
        /// <summary>
        /// Check if a PunctuationRule with this name already exists.
        /// </summary>
        /// <param name="punctuationRuleName">The PunctuationRule's name.</param>
        /// <returns></returns>
        public bool Exists(string punctuationRuleName)
        {
            return _context.PunctuationRules.SingleOrDefault(x => x.Name == punctuationRuleName) != null;
        }
        /// <summary>
        /// Edits a PunctuationRule with the specified changes to apply.
        /// </summary>
        /// <param name="punctuationRule">The PunctuationRule you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the PunctuationRule.</param>
        /// <returns></returns>
        public async Task EditPunctuationRule(PunctuationRule punctuationRule, PunctuationRule changesToApply)
        {
            punctuationRule.Name = changesToApply.Name;
            punctuationRule.Description = changesToApply.Description;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a punctuationRule.
        /// </summary>
        /// <param name="punctuationRule">The punctuationRule to delete.</param>
        public async void Delete(PunctuationRule punctuationRule)
        {
            _context.PunctuationRules.Remove(punctuationRule);
            await _context.SaveChangesAsync();
        }
    }
}
