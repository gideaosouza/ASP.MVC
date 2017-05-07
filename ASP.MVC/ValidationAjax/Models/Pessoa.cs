using System.ComponentModel.DataAnnotations;

namespace ValidationAjax.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }

        [Required(ErrorMessage = "Esse campo precisa ser preenchido")]
        [StringLength(10, ErrorMessage ="O campo {0} precisa ter no máximo {1} carateres e no minimo {2}.", MinimumLength = 3 )]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Esse campo é necessário")]
        public int CPF { get; set; }
    }
}