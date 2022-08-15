using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            //DogViewModel doggo = new DogViewModel()
            //{ Name="BhoteKukur", Age=30};
           // return View(doggo);
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
