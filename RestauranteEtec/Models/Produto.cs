using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Por favor, infome o Nome do Produto")]
        [StringLength(50, ErrorMessage ="O Nome deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Por favor, infome a Descrição do Produto")]
        [StringLength(200, ErrorMessage = "A Descrição deve possuir no máximo 50 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Por favor, informe o Preço do Produto")]
        [Range(0.01, 2000)]
        public double Preco { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Por favor, informe a Categoria do Produto")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Destque?")]
        public bool ExibirHome { get; set; }
    }
}