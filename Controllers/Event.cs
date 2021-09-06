using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LignoCostOnlineTrainingSchool.Controllers
{
    public class Event : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Events";
            return View();
        }
       
    }
}
