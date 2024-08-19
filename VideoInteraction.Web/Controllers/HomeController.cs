using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using VideoInteraction.Models;
using VideoInteraction.Utility;
using VideoInteraction.Web.LangServices;

namespace VideoInteraction.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LanguageService _localization;
        public HomeController(ILogger<HomeController> logger, LanguageService localization)
        {
            _logger = logger;
            _localization = localization;
        }

        public IActionResult Index()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;
            return View();
        }
        public IActionResult ChangeLanguage(string culture)
        {
            if (string.IsNullOrEmpty(culture))
            {
                culture = "en-US";
            }
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return Redirect(Request.Headers["Referer"].ToString());
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
        //public  IActionResult ChangeLanguage(string lang)
        //{
        //    if (!string.IsNullOrEmpty(lang)) {
        //        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
        //        Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

        //    }
        //    else
        //    {
        //        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");
        //        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        //        lang = "en";
        //    }
        //    Response.Cookies.Append("Language", lang);    
        //    return Redirect(Request.GetTypedHeaders().Referer.ToString());
        //}
    }
}
