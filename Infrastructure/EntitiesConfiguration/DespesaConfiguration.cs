﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfiguration
{
    public class DespesaConfiguration :  IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.HasKey(t => t.Id);

            //configura o tamanho máximo das propriedades que irão gerar colunas com tamanho correspondentes. 
            builder.Property(p => p.NomeCategoria).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Valor).HasPrecision(10, 2).IsRequired();
            builder.Property(p => p.Data).IsRequired();
            builder.Property(p => p.Tipo).HasMaxLength(50).IsRequired();
        }
    }
}
