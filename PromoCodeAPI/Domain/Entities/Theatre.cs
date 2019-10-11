using System.Collections.Generic;

namespace PromoCodeAPI.Domain.Entities
{
    public class Theatre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ShoppingCart Cart { get; set; }

    }
}
