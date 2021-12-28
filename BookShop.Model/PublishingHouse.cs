using System;
using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class PublishingHouse : IEquatable<PublishingHouse>
    {
        public PublishingHouse()
        {
            TabEditions = new HashSet<Edition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Edition> TabEditions { get; set; }

        public bool Equals(PublishingHouse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is PublishingHouse other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
