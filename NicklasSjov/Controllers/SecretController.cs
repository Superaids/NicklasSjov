using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NicklasSjov.Controllers
{
    public class SecretController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}