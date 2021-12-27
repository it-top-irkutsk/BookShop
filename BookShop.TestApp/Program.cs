using System;
using System.Linq;
using BookShop.Lib;
using Microsoft.EntityFrameworkCore;

namespace BookShop.TestApp
{
    internal static class Program
    {
        private static void Main()
        {
            using var db = BookShopDb.Init();

            var authors = db.TabAuthors
                .Include(a => a.TabBooks)
                    .ThenInclude(b => b!.IdGenreNavigation)
                .ToList();

            // var authors = db.TabAuthors.ToList();
            
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.Id}: {author.LastName} {author.FirstName}");
                foreach (var book in author.TabBooks)
                {
                    Console.WriteLine($"{book.Id}: {book.Title}, {book.IdGenreNavigation.Name}");
                }
            }
        }
    }
}