using System.ComponentModel.DataAnnotations;
using MovimentacaoContainer.Enum;

namespace MovimentacaoContainer.Models
{
    public class Container
    {
        public int Id { get; set; }

        [StringLength(11)]
        [Required]
        [RegularExpression("^[A-Z]{4}[0-9]{7}$")]
        public string Numero { get; set; }

        [StringLength(255)]
        [Required]
        public string Cliente { get; set; }

        [Required]
        public TipoContainer Type { get; set; }

        [Required]
        public StatusContainer Status { get; set; }

        [Required]
        public CategoriaContainer Categoria { get; set; }

        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}