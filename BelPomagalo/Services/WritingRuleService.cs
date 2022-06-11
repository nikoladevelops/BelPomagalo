using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class WritingRuleService : Service
    {
        public WritingRuleService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all WritingRules' names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllWritingRulesNames()
        {
            return _context.WritingRules
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets the WritingRule with this name.
        /// </summary>
        /// <param name="writingRule">The WritingRule's name.</param>
        /// <returns></returns>
        public WritingRule GetWritingRule(string writingRuleName)
        {
            return _context.WritingRules
                .FirstOrDefault(x => x.Name == writingRuleName);
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
        /// <summary>
        /// Check if a WritingRule with this name already exists.
        /// </summary>
        /// <param name="writingRuleName">The WritingRule's name.</param>
        /// <returns></returns>
        public bool Exists(string writingRuleName)
        {
            return _context.WritingRules.SingleOrDefault(x => x.Name == writingRuleName) != null;
        }
        /// <summary>
        /// Edits a WritingRule with the specified changes to apply.
        /// </summary>
        /// <param name="writingRule">The WritingRule you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the WritingRule.</param>
        /// <returns></returns>
        public async Task EditWritingRule(WritingRule writingRule, WritingRule changesToApply)
        {
            writingRule.Name = changesToApply.Name;
            writingRule.Description = changesToApply.Description;
            await _context.SaveChangesAsync();
        }
    }
}
