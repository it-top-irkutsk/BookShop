using System;
using System.Collections.Generic;
using System.Linq;
using BookShop.Lib;
using BookShop.Model;

namespace BookShop.TestApp
{
    internal static class Program
    {
        private static void Main()
        {
            using var db = BookShopDb.Init();
            
            ShowAuthors(db.TabAuthors);
            Console.Write("Введите номер автора: ");
            var idAuthor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            ShowGenres(db.TabGenres);
            Console.Write("Введите номер жанра: ");
            var idGenre = Convert.ToInt32(Console.ReadLine());

            /*var books = (from book in db.TabBooks
                join author in db.TabAuthors on book.IdAuthor equals author.Id
                join genre in db.TabGenres on book.IdGenre equals genre.Id
                where book.IdAuthor == idAuthor && book.IdGenre == idGenre
                select book).ToList();
            ShowBooks(books);*/
            
            var books2 = from book in db.TabBooks
                join author in db.TabAuthors on book.IdAuthor equals author.Id
                join genre in db.TabGenres on book.IdGenre equals genre.Id
                where book.IdAuthor == idAuthor && book.IdGenre == idGenre
                select book;
            
            ShowBooks(books2);

            /*db.TabBooks.Add(new Book
                {
                    Title = "Воскресенье",
                    IdAuthorNavigation = new Author
                    {
                        LastName = "Толстой",
                        FirstName = "Лев"
                    },
                    IdGenre = 2
                });
            db.SaveChanges();*/
        }

        static void ShowAuthors(IEnumerable<Author> authors)
        {
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.Id}: {author.LastName} {author.FirstName}");
            }
        }

        static void ShowGenres(IEnumerable<Genre> genres)
        {
            foreach (var genre in genres)
            {
                Console.WriteLine($"{genre.Id}: {genre.Name}");
            }
        }

        static void ShowBooks(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Title}; {book.YearOfCreation}");
            }
        }
    }
}