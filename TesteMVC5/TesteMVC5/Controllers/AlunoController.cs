using System;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    [RoutePrefix("Aluno")]
    public class AlunoController : Controller
    {
        [HttpGet]
        [Route("Novo-Aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }

        [HttpPost]
        [Route("Novo-Aluno")]
        public ActionResult NovoAluno(AlunoModel aluno)
        {
            if (!ModelState.IsValid) return View();

            return View("NovoAluno", aluno);
        }

        // GET: Aluno
        public ActionResult Index(AlunoModel aluno)
        {
            if(!ModelState.IsValid) return View(aluno);

            return View(aluno);
        }
    }
}