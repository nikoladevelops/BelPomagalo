﻿using BelPomagalo.Models;
using Microsoft.EntityFrameworkCore;

namespace BelPomagalo.Services
{
    internal class PublishedWorkCharacterService:Service
    {
        public PublishedWorkCharacterService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkCharacter> GetPublishedWorkCharacters(PublishedWork publishedWork)
        {
            return _context.PublishedWorkCharacters
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal IEnumerable<string> GetPublishedWorkCharactersNames(PublishedWork publishedWork)
        {
            return _context.PublishedWorkCharacters
                .Include(x => x.Character)
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .Select(x => x.Character.Name)
                .ToList();
        }
        internal async Task<PublishedWorkCharacter> AddPublishedWorkCharacter(PublishedWorkCharacter publishedWorkCharacter)
        {
            var result = await _context.PublishedWorkCharacters.AddAsync(publishedWorkCharacter);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        internal async Task ChangeCharacters(PublishedWork publishedWork, IEnumerable<Character> newCharacters)
        {
            var publishedWorkCharacters = _context.PublishedWorkCharacters
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();

            _context.PublishedWorkCharacters.RemoveRange(publishedWorkCharacters);
            foreach (var character in newCharacters)
            {
                await _context.PublishedWorkCharacters
                    .AddAsync(new PublishedWorkCharacter() 
                    { PublishedWorkId=publishedWork.Id, CharacterId=character.Id});

            }
            await _context.SaveChangesAsync();
        }
    }
}
