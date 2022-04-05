using System.ComponentModel.DataAnnotations;

namespace MovimentacaoContainer.Enum
{
    public enum CategoriaContainer
    {
        [Display(Name = "Importação")]
        IMPORT,
        [Display(Name = "Exportação")]
        EXPORT
    }
}
