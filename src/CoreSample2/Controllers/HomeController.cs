using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CoreSample2.Models;

namespace CoreSample2.Controllers
{
    public class HomeController : Controller
    {
        readonly ISample sampleRepo;

        public HomeController(ISample sampleRepo)
        {
            this.sampleRepo = sampleRepo;
        }

        public IActionResult Index()
        {
            //Microsoft.AspNetCore.Session
            sampleRepo.setValue(1000);
            HttpContext.Session.SetInt32("sampleValue", sampleRepo.getValue());
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

        public IActionResult Error()
        {
            return View();
        }
    }
}