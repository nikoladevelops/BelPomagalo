﻿using BelPomagalo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class PublishedWorkThemeService : Service
    {
        public PublishedWorkThemeService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkTheme> GetPublishedWorkThemes(PublishedWork publishedWork)
        {
            return _context.PublishedWorkThemes
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal IEnumerable<string> GetPublishedWorkThemesNames(PublishedWork publishedWork)
        {
            return _context.PublishedWorkThemes
                .Include(x => x.Theme)
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .Select(x => x.Theme.Name)
                .ToList();
        }
        internal async Task<PublishedWorkTheme> AddPublishedWorkTheme(PublishedWorkTheme publishedWorkTheme)
        {
            var result = await _context.PublishedWorkThemes.AddAsync(publishedWorkTheme);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        internal async Task ChangeThemes(PublishedWork publishedWork, IEnumerable<Theme> newThemes)
        {
            var publishedWorkThemes = _context.PublishedWorkThemes
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();

            _context.PublishedWorkThemes.RemoveRange(publishedWorkThemes);
            foreach (var theme in newThemes)
            {
                await _context.PublishedWorkThemes
                    .AddAsync(new PublishedWorkTheme()
                    { PublishedWorkId = publishedWork.Id, ThemeId = theme.Id });

            }
            await _context.SaveChangesAsync();
        }
    }
}
