using System.ComponentModel.DataAnnotations;

namespace MovimentacaoContainer.Enum
{
    public enum StatusContainer
    {
        [Display(Name = "Cheio")]
        CHEIO,
        [Display(Name = "Vazio")]
        VAZIO
    }
}
