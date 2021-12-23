#nullable disable

namespace BookShop.Model
{
    public partial class TabPrice
    {
        public int Id { get; set; }
        public int IdEdition { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }

        public virtual TabEdition IdEditionNavigation { get; set; }
    }
}
