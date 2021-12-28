using System;
using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class Genre : IEquatable<Genre>
    {
        public Genre()
        {
            TabBooks = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> TabBooks { get; set; }

        public bool Equals(Genre other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || (obj is Genre other && Equals(other));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
