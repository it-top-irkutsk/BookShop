using System;

#nullable disable

namespace BookShop.Model
{
    public partial class Price : IEquatable<Price>
    {
        public int Id { get; set; }
        public int IdEdition { get; set; }
        public double CostOfEdition { get; set; }
        public double PriceOfEdition { get; set; }

        public virtual Edition IdEditionNavigation { get; set; }

        public bool Equals(Price other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id 
                   && IdEdition == other.IdEdition 
                   && CostOfEdition.Equals(other.CostOfEdition) 
                   && PriceOfEdition.Equals(other.PriceOfEdition);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Price)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IdEdition, CostOfEdition, PriceOfEdition);
        }
    }
}
