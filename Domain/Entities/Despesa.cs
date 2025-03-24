using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Despesa : EntityBase
    {
        public string NomeCategoria { get; set; }
    }
}
