using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Infra.Data.Mappings
{
    /// <summary>
    /// Classe para mapeamento da entidade Usuário no banco de dados
    /// </summary>
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(u => u.Id);
            
            builder.Property(u => u.Id).HasColumnName("Id");
            
            builder.Property(u => u.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.PerfilId)
                .HasColumnName("Perfil_Id")
                .IsRequired();

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasOne(u => u.Perfil) // Usuário TEM 1 Perfil
                .WithMany(u => u.Usuarios) // Perfil TEM muitos Usuários
                .HasForeignKey(u => u.PerfilId) // Chave estrangeira do relacionamento
                .OnDelete(DeleteBehavior.Restrict); // Só permite exluir registros que não possuam vinculo
        }
    }
}
