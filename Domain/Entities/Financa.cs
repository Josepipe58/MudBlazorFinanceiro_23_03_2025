using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Financa : EntityBase
    {
        [Required(ErrorMessage = " O nome da finança é obrigatório."), StringLength(50)]
        public string NomeFinanca { get; set; }

        [Required(ErrorMessage = " O nome da operação é obrigatório."), StringLength(100)]
        public string NomeOperacao { get; set; }
    }
}
