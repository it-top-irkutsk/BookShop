using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class TabGenre
    {
        public TabGenre()
        {
            TabBooks = new HashSet<TabBook>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TabBook> TabBooks { get; set; }
    }
}
