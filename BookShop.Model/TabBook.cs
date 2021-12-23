using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class TabBook
    {
        public TabBook()
        {
            TabEditions = new HashSet<TabEdition>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public short? YearOfCreation { get; set; }
        public int IdGenre { get; set; }

        public TabAuthor IdAuthorNavigation { get; set; }
        public TabGenre IdGenreNavigation { get; set; }
        public ICollection<TabEdition> TabEditions { get; set; }
    }
}
