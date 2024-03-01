using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banco_de_dados_Controllers
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("pessoaId")]
        [Display(Name = "Codigo")]
        public int pessoaId { get; set; }

        [Column("pessoaNome")]
        [Display(Name = "Nome")]
        public string? pessoaNome { get; set; }

        [Column("pessoaCPF")]
        [Display(Name = "CPF")]
        public string? pessoaCPF { get; set; }

        [Column("pessoaRG")]
        [Display(Name = "Identidade")]
        public string? pessoaRG { get; set; }

        [Column("pessoaEmail")]
        [Display(Name = "E-mail")]
        public string? pessoaEmail { get; set; }

        [Column("pessoaTel")]
        [Display(Name = "Telefone")]
        public string? pessoaTel { get; set; }
    }
}


