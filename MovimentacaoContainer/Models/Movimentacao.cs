using System.ComponentModel.DataAnnotations;
using MovimentacaoContainer.Enum;

namespace MovimentacaoContainer.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }

        [Required]
        public TipoMovimentacao Type { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public Container Container { get; set; }

    }
}
