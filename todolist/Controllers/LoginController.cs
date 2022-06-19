//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using System.Linq;
//using todolist.Models;
//namespace todolist.Controllers
//{
//    public class LoginController : Controller
//    {
//        public IActionResult Login()
//        {
//            return View();
//        }
//        public List<UserModel> Putvalue()
//        {
//            var user = new List<UserModel>
//            {
//                new UserModel{id=1 , username = "niraj", password = 123456 },
//                new UserModel{id=2 , username = "admin", password = 123},
//                new UserModel {id=3 , username = "guest", password = 111}
//            };

//            return user;

//        }
//        [HttpPost]
//        public IActionResult Verify(UserModel user)
//        {
//            var u = Putvalue();
//            var ue = u.Where(u => u.username.Equals(user.username));
//            var up = u.Where(u => u.password.Equals(user.password));


//            if (up.Count() == 1)
//            {
//                //ViewBag.message = "Login Success";
//                return View("dashboard");
//            }
//            else
//            {
//                ViewBag.message = "LoginFailed";
//                return View("Login");
//            }
//        }
//    }
//}
