﻿namespace Domain.EntitiesLists
{
    public class Meses
    {
        public decimal Janeiro { get; set; }
        public decimal Fevereiro { get; set; }
        public decimal Marco { get; set; }
        public decimal Abril { get; set; }
        public decimal Maio { get; set; }
        public decimal Junho { get; set; }
        public decimal Julho { get; set; }
        public decimal Agosto { get; set; }
        public decimal Setembro { get; set; }
        public decimal Outubro { get; set; }
        public decimal Novembro { get; set; }
        public decimal Dezembro { get; set; }
        public decimal TotalAno { get; set; }
        public decimal SaldoCarteira { get; set; }
    }
    public class SomarValoresDeDespesa : List<Meses> { }
    public class SomarValoresDeFinanca : List<Meses> { }
}
