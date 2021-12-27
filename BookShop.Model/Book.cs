using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public partial class Book
    {
        public Book()
        {
            TabEditions = new HashSet<Edition>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public short? YearOfCreation { get; set; }
        public int IdGenre { get; set; }

        public Author IdAuthorNavigation { get; set; }
        public Genre IdGenreNavigation { get; set; }
        public ICollection<Edition> TabEditions { get; set; }
    }
}
