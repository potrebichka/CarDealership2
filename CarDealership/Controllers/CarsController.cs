using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allItems = Car.GetAll();
            return View(allItems);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create(string makeModel, int price, int miles)
        {
            Car newCar = new Car(makeModel, price, miles);
            return RedirectToAction("Index");
        }
    }
}