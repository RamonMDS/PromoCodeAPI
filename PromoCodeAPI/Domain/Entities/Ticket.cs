using System;

namespace PromoCodeAPI.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid ShoppingCartId { get; set; }
        public ShoppingCart Cart { get; set; }

    }
}
