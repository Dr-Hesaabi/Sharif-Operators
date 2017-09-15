using Andycabar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andycabar.Controllers
{
    public class AuthController : Controller
    {
        MainModel db = new MainModel();


        // GET: Auth
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            var user = db.SystemOprators.Where(x => x.Username == Username).FirstOrDefault();
            if (user == null)
            {
                ViewBag.Message = "کاربر یافت نشد";
                return View();
            }
            else if (user.Password != Password)
            {
                ViewBag.Message = "کلمه ی عبور اشتباه است";
                return View();
            }
            Session["Username"] = Username;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}