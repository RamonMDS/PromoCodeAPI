using System;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromoCodeAPI.Domain.Interfaces;
using PromoCodeAPI.Services.ViewModelResult;
using PromoCodeAPI.ViewModels;

namespace PromoCodeAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _service;
        
        public ShoppingCartController(IShoppingCartService service)
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([FromBody] ShoppingCartViewModel shoppingCart)
        {
            try
            {
                var results = new ValidationResult();

                var modelResult = _service.Post(shoppingCart, ref results);

                if (!results.IsValid)
                   return  Ok(new ValidatorResult(results));

                               
                return new ObjectResult(modelResult);

            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
