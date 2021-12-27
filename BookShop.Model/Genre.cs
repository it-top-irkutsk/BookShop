using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public sealed partial class Genre
    {
        public Genre()
        {
            TabBooks = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> TabBooks { get; set; }
    }
}
