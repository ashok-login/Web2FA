using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Web2FA.Models;
using Web2FA.Utils;

namespace Web2FA.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Authenticate()
        {
            var authCode = (new AuthCodeProvider()).Generate();
            (new MailSender(_config)).SendMail(authCode);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
