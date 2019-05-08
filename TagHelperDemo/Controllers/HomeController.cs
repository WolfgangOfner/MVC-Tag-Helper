using Microsoft.AspNetCore.Mvc;
using TagHelperDemo.Data;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryRepository _countryRepository;

        public HomeController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public ViewResult Index()
        {
            return View(_countryRepository.Countries);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            _countryRepository.AddCountry(country);

            return RedirectToAction("Index");
        }
    }
}