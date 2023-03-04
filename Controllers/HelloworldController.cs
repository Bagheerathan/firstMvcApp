using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HelloworldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
           
            return View(dogs);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public String Hello()
        {
            return "Hello this is hello function";
        }
    }
}


