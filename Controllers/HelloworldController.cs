using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HelloworldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name =" tommy", 
              Age = 2
            };
            return View(doggo);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("index");
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


