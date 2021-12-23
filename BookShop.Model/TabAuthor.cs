using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class TabAuthor
    {
        public TabAuthor()
        {
            TabBooks = new HashSet<TabBook>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<TabBook> TabBooks { get; set; }
    }
}
