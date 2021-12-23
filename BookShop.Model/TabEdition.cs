using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class TabEdition
    {
        public TabEdition()
        {
            TabPrices = new HashSet<TabPrice>();
        }

        public int Id { get; set; }
        public int IdBook { get; set; }
        public int IdPublishingHouse { get; set; }
        public int NumberOfPages { get; set; }
        public short YearOfPublishing { get; set; }

        public TabBook IdBookNavigation { get; set; }
        public TabPublishingHouse IdPublishingHouseNavigation { get; set; }
        public ICollection<TabPrice> TabPrices { get; set; }
    }
}
