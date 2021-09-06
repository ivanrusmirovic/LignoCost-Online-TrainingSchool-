using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LignoCostOnlineTrainingSchool.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "ContactUs";
            return View();
        }

        public IActionResult JelenaRusimirovic()
        {
            ViewData["Title"] = "ContactUs";
            return View();
        }
    }
}
