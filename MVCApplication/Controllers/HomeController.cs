using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MVCApplication.BLL;
using MVCApplication.Models;
using Newtonsoft.Json.Linq;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private List<User> userDetails;
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult UserDetails()
        //{
        //    return View();
        //}

        [HttpPost]
        public JsonResult UserDetails(Data options)
        {
            List<User> details=new List<User>(); 
            if(options.inputType == "1")
            {
                details = (new UserDetailsBLL(_config)).GetUserDetailsByUserId(options.information);
            }
            else
            {

            }
            return Json(details);
        }
        public ActionResult Show()
        {
            return View();
        }
        public IActionResult ExportToExcel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExportToExcel(UserModel options)
        {
            userDetails = (new UserDetailsBLL(_config)).GetUserDetailsByUserId(options.UserOptions.UserName);
            (new UserDetailsBLL(_config)).ExportToExcel(this, options.UserOptions.UserName);
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
    public class Data
    {
        public string inputType { get; set; }
        public string information { get; set; }
    }
}
