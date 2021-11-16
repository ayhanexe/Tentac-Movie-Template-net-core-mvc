using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tentac_mvc.Controllers
{
    public class MovieDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
