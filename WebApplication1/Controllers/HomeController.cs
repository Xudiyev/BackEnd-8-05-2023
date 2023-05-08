using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Car> _cars;

        public HomeController()
        {
            _cars = new List<Car>
            {
                new Car { id = 1, Oil = 92},
                new Car { id = 2, Year = 2020 }

            };
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                if(!_cars.Exists(s=>s.id==id)) 
                {
                return BadRequest();
                }
                return View(_cars.FindAll(s=>s.id==id));
            }
            return View(_cars);
        }
    }
}
