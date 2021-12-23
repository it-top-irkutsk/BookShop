using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class TabPublishingHouse
    {
        public TabPublishingHouse()
        {
            TabEditions = new HashSet<TabEdition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TabEdition> TabEditions { get; set; }
    }
}
