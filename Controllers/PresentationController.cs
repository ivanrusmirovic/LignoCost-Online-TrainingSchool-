using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LignoCostOnlineTrainingSchool.Controllers
{
    public class PresentationController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Presentations" ;
            var tmp = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files")).Select(f => Path.GetFileName(f)).ToArray();
            return View(tmp);
        }
    }
}
