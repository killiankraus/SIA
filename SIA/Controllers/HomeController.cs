using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIA.Models.Entity;
using SIA.Models.DTO;
using SIA.Models.Repository;
using System.Security.Cryptography;
using System.Text;
//using SIA.Models.Entity;



namespace SIA.Controllers
{

    
    public class HomeController : Controller
    {
        Registration db = new Registration();
        EncryptDecryptRepository encdec = new EncryptDecryptRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult dataTransfer(RegistrationFormDTO data)
        {

            //RegistrationFormRepository reg = new RegistrationFormRepository();

            //bool inserted = reg.insertTodatabase(data);

            //return Json(new { success = inserted });
            return View("Login"); 

        }

    }
}