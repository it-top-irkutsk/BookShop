using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public partial class PublishingHouse
    {
        public PublishingHouse()
        {
            TabEditions = new HashSet<Edition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Edition> TabEditions { get; set; }
    }
}
