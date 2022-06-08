using AutoMapper;
using DmsTask.Abstract;
using DmsTask.Models;
using DmsTask.Provider;
using Microsoft.AspNetCore.Mvc;

namespace DmsTask.Controllers
{
    public class UserOperationsController : Controller
    {
        private IProductRepository _printerRepo;
        [ActivatorUtilitiesConstructorAttribute]
        public UserOperationsController(IProductRepository printerRepository)
        {
            _printerRepo = printerRepository;
        }

        public UserOperationsController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddPrinter()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddPrinter(PrinterModel model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            _printerRepo.AddPrinter(model);
            _printerRepo.complete();
            return View();
        }
[HttpGet]
        public IActionResult AddLaptop()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddLaptop(LaptopModel model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            _printerRepo.AddLaptop(model);
            _printerRepo.complete();
            return View();
        }

        public IActionResult GetAlldevices()
        {
            var products = _printerRepo.GetAlLaptops();
            return View(products);
        }
        [HttpGet]
        public IActionResult UpdatePrinter(int id)
        {

            return View(_printerRepo.GetPrinter(id));
        }
        [HttpPost]
        public IActionResult UpdatePrinter(PrinterModel model)
        {
            _printerRepo.UpdatePrinter(model);
            _printerRepo.complete();
            return View();
        }
        [HttpGet]
        public IActionResult UpdateLaptop(int id)
        {

            return View(_printerRepo.GetLaptop(id));
        }
        [HttpPost]
        public IActionResult UpdateLaptop(LaptopModel model)
        {
            _printerRepo.UpdateLabtop(model);
            _printerRepo.complete();
            return View();
        }




    }
}
