using System.ComponentModel.DataAnnotations;
using MovimentacaoContainer.Enum;

namespace MovimentacaoContainer.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }

        [Required]
        public TipoMovimentacao Tipo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataHoraInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataHoraFim { get; set; }

        [Required]
        public Container Container { get; set; }

    }
}
