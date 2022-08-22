using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteMVC5.Models
{
    public class AlunoModel
    {
        public int Id { get; set; }

        [DisplayName("Nome Completo")]
        [Required (ErrorMessage = "O campo {0} é requerido.")] //Requirido
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [Required (ErrorMessage = "o campo {0} é requerido.")]
        [EmailAddress(ErrorMessage = "E-mail com o formato invalido")]
        public string Email { get; set; }

        [Required (ErrorMessage = "O campo {0} é requirido.")]
        public string CPF { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }

        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas informadas não conferem.")]
        [Required(ErrorMessage = "O campo {0} é requirido.")]
        public string SenhaConfirmacao { get; set; }

        //Pesquisar como criar seu proprio DataAnnotations.
    }
}