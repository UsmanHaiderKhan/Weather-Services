using System.Web.Mvc;
using Weather_Services.Models;

namespace Weather_Services.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WeatherOrNot()
        {
            return View();
        }

        public JsonResult GetWeather()
        {
            Weather weather = new Weather();
            return Json(weather.GetWeatherForcast(), JsonRequestBehavior.AllowGet);

        }
    }
}
