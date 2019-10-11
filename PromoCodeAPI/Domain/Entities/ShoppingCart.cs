using System;
using System.Collections.Generic;

namespace PromoCodeAPI.Domain.Entities
{
    public class ShoppingCart
    {
        public Guid _id { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }
        public int TheatreId { get; set; }
        public int MovieId { get; set; }
        public Theatre Theatre { get; set; }
        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
