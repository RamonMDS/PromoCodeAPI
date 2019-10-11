using FluentValidation;
using PromoCodeAPI.Domain.Entities;
using System.Collections.Generic;

namespace PromoCodeAPI.Domain.Interfaces
{
   public interface IPromoCodeService<T> where T : Entity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;
        T Put<V>(T obj) where V : AbstractValidator<T>;
        void Delete(int id);
        T Get(int id);
        IList<T> GetAll();

    }    
}
