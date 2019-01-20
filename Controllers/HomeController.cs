using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BTVBookRental.Models;
using Microsoft.AspNetCore.Http;

namespace BTVBookRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly BTVBookRentalContext _context;

        public HomeController(BTVBookRentalContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.UserAccount.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount user)
        {
            if(ModelState.IsValid)
            {
                _context.UserAccount.Add(user);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + " s-a inregistrat cu succes.";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {

            var account = _context.UserAccount.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();

            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.UserId.ToString());
                HttpContext.Session.SetString("Username", account.Username);
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "Utilizatorul sau parola au fost introduse gresit");
            }
            return View();
        }


        public ActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
