using Microsoft.EntityFrameworkCore;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Domain.Interfaces;
using PromoCodeAPI.Infra.Context;
using System.Linq;

namespace PromoCodeAPI.Infra.Data.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ContextSqlLite _context;
        public ShoppingCartRepository(ContextSqlLite context)
        {
            _context = context;
        }
        public PromoCode GetCode(string code)
        {
            return _context.PromoCodes.SingleOrDefault(x => x.Code == code);
        }

        public Movie GetMovie(int movieId)
        {
            return _context.Movies.SingleOrDefault(x => x.Id == movieId);
        }
        public Theatre GetTheatre(int theatreId)
        {
            return _context.Theatres.SingleOrDefault(x => x.Id == theatreId);
        }

        public Promotion GetPromotion(string code)
        {
            return _context.Promotions
                .Include(x => x.Codes.Where(o => o.Code == code)).Single();
                
        }
    }
}