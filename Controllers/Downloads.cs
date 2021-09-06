using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace LignoCostOnlineTrainingSchool.Controllers
{
    public class Downloads : Controller
    {
        [HttpGet]
        public ActionResult Download(string fileName)
        {
            var tmp2 = PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", string.Format("Files/{0}", fileName)), "text/plain", fileName);
            return tmp2;


        }
        
    }
}
