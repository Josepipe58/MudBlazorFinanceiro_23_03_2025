using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da descrição é obrigatório."), StringLength(200)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = " O valor é obrigatório."), Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }

        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "O tipo é obrigatório."), StringLength(50)]
        public string Tipo { get; set; }
    }
}
