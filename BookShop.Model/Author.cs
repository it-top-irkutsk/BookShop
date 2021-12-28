using System;
using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class Author : IEquatable<Author>
    {
        public Author()
        {
            TabBooks = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Book> TabBooks { get; set; }

        public bool Equals(Author other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id 
                   && FirstName == other.FirstName 
                   && LastName == other.LastName;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is Author other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName);
        }
    }
}
