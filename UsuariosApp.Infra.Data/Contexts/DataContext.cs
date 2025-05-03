using Microsoft.EntityFrameworkCore;
using UsuariosApp.Infra.Data.Mappings;

namespace UsuariosApp.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //adicionar o caminho da connecionstring do banco de dados
            optionsBuilder.UseSqlServer("Data Source=localhost,1435;Initial Catalog=master;User ID=sa;Password=Coti@2025;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento de entidade do projeto
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }

    }
}
