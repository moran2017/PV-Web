using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PV.Web.ViewModel;
using PV.Web.Models;

namespace PV.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        //DasBoard
        public ActionResult Dashboard()
        {
            DashboardViewModel objViewModel = new DashboardViewModel();

            return View(objViewModel);
        }

        //view login get
        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModels objViewMolel = new LoginViewModels();

            return View(objViewMolel);

        }

        //Login  post
        [HttpPost]
        public ActionResult Login(LoginViewModels objViewModel)
        {
            PVPruebasEntities context = new PVPruebasEntities();

            login objUsuario = context.login.FirstOrDefault(X => X.Usuario == objViewModel.Usuario
            && X.Password == objViewModel.Password);

            if (objUsuario == null)
            {
                return View(objViewModel);
            }
            else
            {
                ViewBag.Error = "Todos lo campos deben ser llenados";
            }

            Session["objUsuario"] = objUsuario;
            return RedirectToAction("DashBoard");

        }

        // cerrar seion
        public ActionResult CerrarSesion()
        {
            Session.Clear();
            return RedirectToAction("Login");
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
    }
}