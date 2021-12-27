using System.Collections.Generic;

#nullable disable

namespace BookShop.Model
{
    public partial class Author
    {
        public Author()
        {
            TabBooks = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Book> TabBooks { get; set; }
    }
}
