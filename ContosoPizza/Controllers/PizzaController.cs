using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
            PizzaService.GetAll();

        /// <summary>
        /// Get by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            PizzaService.Add(pizza);

            return Ok(pizza);
        }

        /// <summary>
        /// Put
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if (id != pizza.Id)
                return BadRequest();

            var existingPizza = PizzaService.Get(id);

            if (existingPizza is null)
                return NotFound();

            PizzaService.Update(pizza);

            return NoContent();
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza is null)
                return NotFound();

            PizzaService.Delete(id);

            return NoContent();
        }
    }
}
