using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(200, ErrorMessage = "O campo deve possuir no máximo 200 caracteres")]
        public string Texto { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Por favor, informe o Cargo do Funcionario")]
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }

        public bool ExibirHome { get; set; }

        public byte OrdemExibicao { get; set; }
    }
}
