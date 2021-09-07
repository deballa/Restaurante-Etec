using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Relato")]
    public class Relato
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(500, ErrorMessage = "O campo deve possuir no máximo 1000 caracteres")]
        public string Texto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo deve possuir no máximo 60 caracteres")]
        public string NomePessoa { get; set; }

        [StringLength(200)]
        public string FotoPessoa { get; set; }

        [StringLength(30)]
        public string TipoPessoa { get; set; }

        public bool ExibirHome { get; set; }
    }
}
