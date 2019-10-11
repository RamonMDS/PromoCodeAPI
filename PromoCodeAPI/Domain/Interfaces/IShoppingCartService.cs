using FluentValidation.Results;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Services.ViewModelResult;
using PromoCodeAPI.ViewModels;

namespace PromoCodeAPI.Domain.Interfaces
{
    public interface IShoppingCartService
    {
        ShoppingCartResult Post(ShoppingCartViewModel shoppingCart, ref ValidationResult results);
      
    }
}
