using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfiguration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.NomeCategoria).IsRequired();
        }
    }
}
