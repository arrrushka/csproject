using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeansOffice.Web.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        public IActionResult SignIn()
        {
            return Ok();
        }

        public IActionResult Register()
        {
            return Ok();
        }

        public IActionResult SignOut()
        {
            return Ok();
        }
    }
}
