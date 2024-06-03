using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models;

    [Table("Avaliacao")]
    public class Avaliacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir até 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe sua Avaliação")]
        [StringLength(300, ErrorMessage = "A avaliação deve possuir no máximo 300 caracteres")]
        public string Texo { get; set; }

        [Display(Name = "Data da Avaliação")]
        public DateTime DateAvaliacao { get; set; } = DateTime.Now;

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "Informe o Produto")]
        public int ProdutoId { get; set; }
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
    }