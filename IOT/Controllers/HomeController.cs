using IOT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IOT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        GreenHouseContext context = new GreenHouseContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            string? temprature = context.Tempratures.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();
            string? rain = context.Rains.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();
            string? light = context.Lights.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();
            string? moisture = context.Moistures.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();

            ViewBag.Temprature = temprature;
            ViewBag.Rain = rain;
            ViewBag.Light = light;
            ViewBag.Moisture = moisture;


            return View();
        }

        public string Temprature()
        {
            string? temprature = context.Tempratures.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();

            return temprature == null ? "" : temprature;
        }
        public string Rain()
        {
            string? rain = context.Rains.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();

            return rain == null ? "" : rain;
        }
        public string Light()
        {
            string? light = context.Lights.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();

            return light == null ? "" : light;
        }
        public string Moisture()
        {
            string? moisture = context.Moistures.OrderByDescending(a => a.CreatedDate).Select(a => a.Value).FirstOrDefault();

            return moisture == null ? "" : moisture;
        }

        public bool TempratureAction(string effect, string actions)
        {
            TempratureAction temprature = new TempratureAction();

            temprature.Effect = effect;
            temprature.Action = actions;
            temprature.CreatedDate = DateTime.Now;

            try
            {
                context.TempratureActions.Add(temprature);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }         
        }

        public bool MoistureAction(string effect, string actions)
        {
            MoistureAction moisture = new MoistureAction();

            moisture.Effect = effect;
            moisture.Action = actions;
            moisture.CreatedDate = DateTime.Now;

            try
            {
                context.MoistureActions.Add(moisture);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RainAction(string effect, string actions)
        {
            RainAction rain = new RainAction();

            rain.Effect = effect;
            rain.Action = actions;
            rain.CreatedDate = DateTime.Now;

            try
            {
                context.RainActions.Add(rain);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool LightAction(string effect, string actions)
        {
            LightAction light = new LightAction();

            light.Effect = effect;
            light.Action = actions;
            light.CreatedDate = DateTime.Now;

            try
            {
                context.LightActions.Add(light);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
