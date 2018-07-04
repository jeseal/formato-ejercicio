using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormatoDeEjercicios.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var Message = new Ejercicio1();
            Message.Ejercicio();
            
            return Content(Message.Message);
        }
    }
}