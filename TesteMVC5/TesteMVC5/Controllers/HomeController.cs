using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    [RoutePrefix("Renegociacao-de-Taxa")]
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            return View(); 
        }

        [Route("Sobre-nós")]
        public ActionResult About()
        {
            return View();
        }

        [Route("Institucional/Contatos")]
        public ActionResult Contact()
        {
            return View();
        }

         public ContentResult ContentResult()
        {
            return Content("olá");
        }

        [Route("download/foto")]
        public FileContentResult SearchFileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/Content/img/photo.jpeg"));
                return File(foto, "img/photo", "Foto-Bernardo.jpeg");
        }

        public EmptyResult EmptyResult()
        {
            return EmptyResult();
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult("403");
        }

        public JsonResult JsonReturn()
        {
            return Json("Nome: 'William'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectNewView()
        {
            return Redirect("https://Desenvolvedor.io");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            //return RedirectToRoute(new
            //{
            //    controller = "Cliente",
            //    action = "Cadastro"
            //});

            return RedirectToAction("Cadastro", "Cliente");
        }
    }
}