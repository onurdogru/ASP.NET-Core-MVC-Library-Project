using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebUygulamaProje1.Models;

namespace WebUygulamaProje1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //View/Home klasöründeki index.cshtml ifade eder.
        {
            return View(); //Burada parantez içine "" içinde ne yazarsan, Views içindeki o html sayfası gelir.
                            //Yani ilk açılan sayfayıda buraya "" içinde yazarak belirleyebiliriz.
        }




        public IActionResult Privacy()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
