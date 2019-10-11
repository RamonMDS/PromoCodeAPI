using System.Collections.Generic;

namespace PromoCodeAPI.ViewModels
{
    public class SessionsViewModel
    {
        public string Date { get; set; }
        public EventViewModel Event { get; set; }
        public TheatreViewModel Theatre { get; set; }
        public List<TicketsViewModel> Tickets { get; set; }
    }
}
