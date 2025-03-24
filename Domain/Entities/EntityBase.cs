﻿namespace Domain.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? Data { get; set; }
        public string Tipo { get; set; }
    }
}
