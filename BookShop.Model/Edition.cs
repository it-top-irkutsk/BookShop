using System;
using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class Edition : IEquatable<Edition>
    {
        public Edition()
        {
            TabPrices = new HashSet<Price>();
        }

        public int Id { get; set; }
        public int IdBook { get; set; }
        public int IdPublishingHouse { get; set; }
        public int NumberOfPages { get; set; }
        public short YearOfPublishing { get; set; }

        public Book IdBookNavigation { get; set; }
        public PublishingHouse IdPublishingHouseNavigation { get; set; }
        public ICollection<Price> TabPrices { get; set; }

        public bool Equals(Edition other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id 
                   && IdBook == other.IdBook 
                   && IdPublishingHouse == other.IdPublishingHouse 
                   && NumberOfPages == other.NumberOfPages 
                   && YearOfPublishing == other.YearOfPublishing;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is Edition other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IdBook, IdPublishingHouse, NumberOfPages, YearOfPublishing);
        }
    }
}
