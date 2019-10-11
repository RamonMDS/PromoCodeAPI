using PromoCodeAPI.Domain.Status;

namespace PromoCodeAPI.Domain.Entities
{
    public class PromoCode : Entity
    {
        public string Code { get; set; }
        public StatusPromoCode Status { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }

    }
}
