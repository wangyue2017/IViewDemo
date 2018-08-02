using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IViewDemo.Controllers
{
    public class AffixController : Controller
    {
        public IActionResult Affix()
        {
            return View();
        }
    }
}