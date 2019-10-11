using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Domain.Interfaces;
using PromoCodeAPI.Domain.Status;
using PromoCodeAPI.Services.ViewModelResult;
using PromoCodeAPI.ViewModels;
using System;

namespace PromoCodeAPI.Services.Communication
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IValidator<ShoppingCartViewModel> _validator;
        private readonly IMapper _mapper;
        private readonly IShoppingCartRepository _repository;
        public ShoppingCartService(IValidator<ShoppingCartViewModel> validator
                                   , IMapper mapper
                                   , IShoppingCartRepository repository)
        {
            _validator = validator;
            _mapper = mapper;
            _repository = repository;
        }
        public ShoppingCartResult Post(ShoppingCartViewModel shoppingCart, ref ValidationResult results)
        {
            results = _validator.Validate(shoppingCart);
            
            if (!results.IsValid)
                return new ShoppingCartResult();

            if (!ExistsPromoCode(shoppingCart.PromoCode))
                 results.Errors.Add(AddFailure("PromoCode", "has already been used"));
            if (!ExistsMovie(shoppingCart.Sessions.Event.Id))
                 results.Errors.Add(AddFailure("Movie", "Movie not found"));
            if (!ExistsTheatre(shoppingCart.Sessions.Theatre.Id))
                results.Errors.Add(AddFailure("Theatre", "Theatre not found"));

            if (!results.IsValid)
                return new ShoppingCartResult();



            return new ShoppingCartResult { _Id = Guid.NewGuid() };
        }   

        private ValidationFailure AddFailure(string property, string error)
        {
          return new ValidationFailure(property, error);           
        }

        private bool ExistsPromoCode(string code)
        {
            var promoCode = _repository.GetCode(code);

            return promoCode == null ? false : promoCode.Status == StatusPromoCode.Active;
        }
        private bool ExistsMovie(int movieId)
        {
            var movie = _repository.GetMovie(movieId);

            return movie != null;
        }
        private bool ExistsTheatre(int movieId)
        {
            var theatre = _repository.GetTheatre(movieId);

            return theatre != null;
        }
    }
}
