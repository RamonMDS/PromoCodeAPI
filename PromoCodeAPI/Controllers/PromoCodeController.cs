using System;
using Microsoft.AspNetCore.Mvc;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Domain.Interfaces;

namespace PromoCodeAPI.Controllers
{/*
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PromoCodeController : Controller
    {
        private readonly IPromoCodeService<PromoCode> _promoCodeService;
        public PromoCodeController(IPromoCodeService<PromoCode> promoCodeService)
        {
            _promoCodeService = promoCodeService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PromoCode code)
        {
            try
            {
           

                return new ObjectResult(code.Id);
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
        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] PromoCode code)
        {
            try
            {
            

                return new ObjectResult(code);
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
        // Get api/values/5
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_promoCodeService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)  {
            try
            {
                return new ObjectResult(_promoCodeService.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }*/
}
