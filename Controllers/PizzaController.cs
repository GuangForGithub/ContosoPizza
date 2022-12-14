using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
   private readonly PizzaService _service;
  public PizzaController(PizzaService service)
  {
    _service = service;
  }

  // GET all action
  [HttpGet]
  public IEnumerable<Pizza> GetAll()
  {
    //return _service.GetAll();
  }

  //// GET by Id action
  //[HttpGet("{id}")]
  //public ActionResult<Pizza> GetById(int id)
  //{
  //  var pizza = _service.GetById(id);

  //  if (pizza is not null)
  //  {
  //    return pizza;
  //  }
  //  else
  //  {
  //    return NotFound();
  //  }
  //}

  //// POST action
  //[HttpPost]
  //public IActionResult Create(Pizza newPizza)
  //{
  //  var pizza = _service.Create(newPizza);
  //  return CreatedAtAction(nameof(GetById), new { id = pizza!.Id }, pizza);
  //}

  //// PUT action
  //[HttpPut("{id}/addtopping")]
  //public IActionResult AddTopping(int id, int toppingId)
  //{
  //  var pizzaToUpdate = _service.GetById(id);

  //  if (pizzaToUpdate is not null)
  //  {
  //    _service.AddTopping(id, toppingId);
  //    return NoContent();
  //  }
  //  else
  //  {
  //    return NotFound();
  //  }
  //}

  //[HttpPut("{id}/updatesauce")]
  //public IActionResult UpdateSauce(int id, int sauceId)
  //{
  //  var pizzaToUpdate = _service.GetById(id);

  //  if (pizzaToUpdate is not null)
  //  {
  //    _service.UpdateSauce(id, sauceId);
  //    return NoContent();
  //  }
  //  else
  //  {
  //    return NotFound();
  //  }
  //}

  //// DELETE action
  //[HttpDelete("{id}")]
  //public IActionResult Delete(int id)
  //{
  //  var pizza = _service.GetById(id);

  //  if (pizza is not null)
  //  {
  //    _service.DeleteById(id);
  //    return Ok();
  //  }
  //  else
  //  {
  //    return NotFound();
  //  }
  //}
}