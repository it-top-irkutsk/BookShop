#nullable disable

namespace BookShop.Model
{
    public partial class Price
    {
        public int Id { get; set; }
        public int IdEdition { get; set; }
        public double CostOfEdition { get; set; }
        public double PriceOfEdition { get; set; }

        public Edition IdEditionNavigation { get; set; }
    }
}
