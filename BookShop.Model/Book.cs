using System;
using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class Book : IEquatable<Book>
    {
        public Book()
        {
            TabEditions = new HashSet<Edition>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public short? YearOfCreation { get; set; }
        public int IdGenre { get; set; }

        public Author IdAuthorNavigation { get; set; }
        public Genre IdGenreNavigation { get; set; }
        public ICollection<Edition> TabEditions { get; set; }

        public bool Equals(Book other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id 
                   && Title == other.Title 
                   && IdAuthor == other.IdAuthor 
                   && YearOfCreation == other.YearOfCreation 
                   && IdGenre == other.IdGenre;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || (obj is Book other && Equals(other));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, IdAuthor, YearOfCreation, IdGenre);
        }
    }
}
