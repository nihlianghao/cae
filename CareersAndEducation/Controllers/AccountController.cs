using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using CareersAndEducation.Models;

namespace CareersAndEducation.Controllers
{

    public class AccountController : Controller
    {
        //get
        public ActionResult Index()
        {
            return View();
        }
        //get
        public ActionResult S_Register()
        {
            return View();
        }

        //Account/S_Register
        [HttpPost]
        public ActionResult S_Register(Student account)
        {
            if (ModelState.IsValid)
            {
                using (CareerDbContext db = new CareerDbContext())
                {

                    db.Identities.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Email + " successfully registered";
                Session["email"] = account.Email;
            }
            return RedirectToAction("Index", "Home");

        }
        //get
        public ActionResult O_Register()
        {
            return View();
        }
        //Account/O_Register
        [HttpPost]
        public ActionResult O_Register(Organization account)
        {
            if (ModelState.IsValid)
            {
                using (CareerDbContext db = new CareerDbContext())
                {

                    db.Identities.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Email + " successfully registered";
                Session["email"] = account.Email;
            }
            return RedirectToAction("Index", "Home");
        }
        //get
        public ActionResult Login()
        {
            return View();
        }

        //Account/Login
        [HttpPost]
        public ActionResult Login(Identity account)
        {
            using (CareerDbContext db = new CareerDbContext())
            {
                var user = db.Identities.SingleOrDefault(u => u.Email == account.Email && u.Password == account.Password);
                if (user != null)
                {
                    Session["email"] = account.Email;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Please try again!");
                }
            }
            return View();
        }
        //Account/LogOff
        [HttpPost]
        public ActionResult LogOff()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}
    