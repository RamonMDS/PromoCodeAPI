using PromoCodeAPI.Domain.Entities;
using System.Collections.Generic;

namespace PromoCodeAPI.Domain.Interfaces
{
    public interface IPromoCodeRepository<T> where T : Entity
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        T Select(int id);
        IList<T> Select();

    }
}
