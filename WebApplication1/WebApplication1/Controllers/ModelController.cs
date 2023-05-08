using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _model;

        public ModelController()
        {
            _model = new List<Model>
            {
                new Model { id = 1, ModelName= "X5M"},

            };
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
