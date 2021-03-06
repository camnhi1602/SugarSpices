using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPlace_2022_.Shared;

namespace PizzaPlace_2022_.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private static readonly List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza(1, "Pepperoni",8.99M,Spiciness.Spicy),
            new Pizza(2, "Margarita",7.99M,Spiciness.None),
            new Pizza(3, "Diaole",9.99M,Spiciness.Hot)
        };
        [HttpGet("/pizzas")]
        public IQueryable<Pizza> GetPizzas()
            => pizzas.AsQueryable();
    }
}
