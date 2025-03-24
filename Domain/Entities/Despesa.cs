using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Despesa : EntityBase
    {
        [Required(ErrorMessage = " O nome da categoria é obrigatório."), StringLength(100)]
        public string NomeCategoria { get; set; }
    }
}
