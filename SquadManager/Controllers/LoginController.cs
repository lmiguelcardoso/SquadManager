using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validations;

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        { 
            var user = new UserViewModel();
            return View(user);
        }

        //[HttpPost]
        //public IActionResult Teste(UserViewModel user)
        //{
        //    var validator = new UserValidator();
        //    var result = validator.Validate(user);

        //    if (!result.IsValid)
        //    {
        //        foreach (var failure in result.Errors)
        //        {
        //            Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
        //        }
        //    }
        //    return View("Index",user);
        //}

        public IActionResult SignUp()
        {
 
            return View("SignUp");
        }
    }
}
