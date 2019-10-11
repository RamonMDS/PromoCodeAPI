using Microsoft.AspNetCore.Mvc;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Services;

namespace PromoCodeAPI.Controllers
{
    //[Route("api/theatres")]
    //public class TheatreController : Controller
    //{
    //    private ITheatreService _theatreService;

    //    public TheatreController(ITheatreService theatreService)
    //    {
    //        _theatreService = theatreService;
    //    }

    //    // GET: api/<controller>
    //    [HttpGet]
    //    public IActionResult Get()
    //    {
    //        return Ok(_theatreService.FindAll());
    //    }

    //    // GET api/<controller>/5
    //    [HttpGet("{id}")]
    //    public IActionResult Get(int id)
    //    {
    //        var theatre = _theatreService.FindById(id);
    //        if (theatre == null) return NotFound();
    //        return Ok(theatre);
    //    }

    //    // POST api/<controller>
    //    [HttpPost]
    //    public IActionResult Post([FromBody]Theatre theatre)
    //    {
    //        if (theatre == null) return BadRequest();
    //        return new ObjectResult(_theatreService.Create(theatre));
    //    }

    //    // PUT api/<controller>/5
    //    [HttpPut("{id}")]
    //    public IActionResult Put(int id, [FromBody]Theatre theatre)
    //    {
    //        if (theatre == null) return BadRequest();
    //        return new ObjectResult(_theatreService.Create(theatre));
    //    }

    //    // DELETE api/<controller>/5
    //    [HttpDelete("{id}")]
    //    public IActionResult Delete(int id)
    //    {
    //        _theatreService.Delete(id);
    //        return NoContent();
    //    }
    //}
}
