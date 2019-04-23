using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlackPositivitySubmissionSite.Models;
using BlackPositivity.Services.Abstractions.ServiceAbstractions;
using BlackPositivity.Services.Models;

namespace BlackPositivitySubmissionSite.Controllers
{
    public class HomeController : Controller
    {
        public BlackPositivityQuoteController _bPQC { get; set; }

        public HomeController(IQuoteService qs)
        {
            _bPQC = new BlackPositivityQuoteController(qs);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BlackPositivtyQuote quote)
        {
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
