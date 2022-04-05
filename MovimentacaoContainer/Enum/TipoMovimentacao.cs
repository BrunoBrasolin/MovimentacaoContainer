using System.ComponentModel.DataAnnotations;

namespace MovimentacaoContainer.Enum
{
    public enum TipoMovimentacao
    {
        [Display(Name = "Embarque")]
        EMBARQUE,
        [Display(Name = "Descarga")]
        DESCARGA,
        [Display(Name = "Gate In")]
        GATE_IN,
        [Display(Name = "Gate out")]
        GATE_OUT,
        [Display(Name = "Posicionamento Pilha")]
        POSICIONAMENTO,
        [Display(Name = "Pesagem")]
        PESAGEM,
        [Display(Name = "Scanner")]
        SCANNER
    }
}
