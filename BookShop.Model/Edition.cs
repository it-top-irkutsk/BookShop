using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class Edition
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
    }
}
