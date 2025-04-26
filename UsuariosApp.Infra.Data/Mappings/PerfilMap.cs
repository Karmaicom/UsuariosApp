using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Infra.Data.Mappings
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        /// <summary>
        /// Classe para mapeamento da entidade Perfil no banco de dados
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("Perfil");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("Id");
            
            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(25)
                .IsRequired();

            builder.HasIndex(p => p.Nome).IsUnique();
        }
    }
}
