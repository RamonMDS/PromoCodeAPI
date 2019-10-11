using FluentValidation;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace PromoCodeAPI.Services.Implamentations
{
    public class PromoCodeService<T> : IPromoCodeService<T> where T : Entity
    {
        private readonly IPromoCodeRepository<T>  _codeRepository;

        public PromoCodeService(IPromoCodeRepository<T> codeRepository)
        {
            _codeRepository = codeRepository;
        }

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());
            _codeRepository.Insert(obj);

            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            _codeRepository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            _codeRepository.Delete(id);
        }

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            return _codeRepository.Select(id);
        }

        public IList<T> GetAll()
        {
           return _codeRepository.Select();
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Register not found!");

            validator.ValidateAndThrow(obj);
        }
    }
}
