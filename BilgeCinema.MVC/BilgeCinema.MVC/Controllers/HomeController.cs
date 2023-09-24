using BilgeCinema.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BilgeCinema.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;
        public HomeController(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.AppName = _appSettings.ApplicationName;

            var getAllUrl = $"{_appSettings.ApiBaseUrl}/movies";
            
            using var client = new HttpClient();

            var response = await client.GetFromJsonAsync<List<MovieViewModel>>(getAllUrl);
            // Json formatındaki verileri, class formatına çektim.

            return View(response);
        }
    }
}
