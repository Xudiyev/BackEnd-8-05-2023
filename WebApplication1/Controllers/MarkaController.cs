using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MarkaController : Controller
    {
        private readonly List<Marka> _marka;

        public MarkaController()
        {
            _marka = new List<Marka>
            {
                new Marka { id = 1, MarkaName= "BMW"},

            };
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
