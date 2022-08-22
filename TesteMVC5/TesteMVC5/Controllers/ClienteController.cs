using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    [RoutePrefix("Retencao")]
    public class ClienteController : Controller
    {
        // GET: Cliente
        [Route("{teste:int}/{texto:length(1,10)}")]
        public ActionResult Index(int teste, string texto)
        {
            return View();
        }

        [Route("Cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}