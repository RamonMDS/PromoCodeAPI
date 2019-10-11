
namespace PromoCodeAPI.ViewModels
{
    public class ShoppingCartViewModel 
    {
        public string Date { get; set; }
        public double TotalPrice { get; set; }
        public string PromoCode { get; set; }
        public SessionsViewModel Sessions { get; set; }
        
    }
}
