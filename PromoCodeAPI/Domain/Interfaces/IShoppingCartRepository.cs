using PromoCodeAPI.Domain.Entities;

namespace PromoCodeAPI.Domain.Interfaces
{
    public interface IShoppingCartRepository
    {

        PromoCode GetCode(string promocode);
        Movie GetMovie(int movieId);
        Theatre GetTheatre(int theatreId);

    }
}
