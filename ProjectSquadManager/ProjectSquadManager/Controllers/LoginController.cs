using Microsoft.AspNetCore.Mvc;
using ProjectSquadManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            
            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "email enviado";

            return View("Index", user);
        }
    }
}
