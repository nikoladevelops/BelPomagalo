﻿using BelPomagalo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class PublishedWorkGenreService : Service
    {
        public PublishedWorkGenreService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkGenre> GetPublishedWorkGenres(PublishedWork publishedWork)
        {
            return _context.PublishedWorkGenres
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal IEnumerable<string> GetPublishedWorkGenresNames(PublishedWork publishedWork)
        {
            return _context.PublishedWorkGenres
                .Include(x => x.Genre)
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .Select(x => x.Genre.Name)
                .ToList();
        }
        internal async Task<PublishedWorkGenre> AddPublishedWorkGenre(PublishedWorkGenre publishedWorkGenre)
        {
            var result = await _context.PublishedWorkGenres.AddAsync(publishedWorkGenre);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        internal async Task ChangeGenres(PublishedWork publishedWork, IEnumerable<Genre> newGenres)
        {
            var publishedWorkGenres = _context.PublishedWorkGenres
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();

            _context.PublishedWorkGenres.RemoveRange(publishedWorkGenres);
            foreach (var genre in newGenres)
            {
                await _context.PublishedWorkGenres
                    .AddAsync(new PublishedWorkGenre()
                    { PublishedWorkId = publishedWork.Id, GenreId = genre.Id });

            }
            await _context.SaveChangesAsync();
        }
    }
}
