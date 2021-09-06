using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace LignoCostOnlineTrainingSchool.Controllers
{
    public class IndexController : Controller
    {
        [HttpPost]
        public IActionResult Index(IFormFile files)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    var fileName = Path.GetFileName(files.FileName);

                    var myUniquefileName = Convert.ToString(Guid.NewGuid());

                    var fileExtencion = Path.GetExtension(fileName);

                    var newFileName = string.Concat(myUniquefileName, fileExtencion);

                    var filepath =
                        new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";

                    using(FileStream fs = System.IO.File.Create(filepath))
                    {
                        files.CopyTo(fs);
                        fs.Flush();
                    }

                }
            }
            return View();
        }
    }
}
