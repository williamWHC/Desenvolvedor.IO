using System;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    [RoutePrefix("Aluno")]
    public class AlunoController : Controller
    {
        [Route("Novo-Aluno")]
        public ActionResult Novo(AlunoModel aluno)
        {
            aluno = new AlunoModel()
            {
                Id = 1,
                Nome = "William",
                Email = "email@hotmail.com",
                CPF = "37709087833",
                DataMatricula = new DateTime(),
                Ativo = true,
                Senha = "123",
                SenhaConfirmacao = "123"

            };

            return RedirectToAction("index", aluno);
        }

        // GET: Aluno
        public ActionResult Index(AlunoModel aluno)
        {
            if(!ModelState.IsValid) return View(aluno);

            return View(aluno);
        }
    }
}