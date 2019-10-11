using PromoCodeAPI.Domain.Enums;
using System.Collections.Generic;

namespace PromoCodeAPI.Domain.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DiscountValue { get; set; }
        public PromotionType PromotionType { get; set; }
        public ICollection<PromoCode> Codes { get; set; } 

    }
 
}
