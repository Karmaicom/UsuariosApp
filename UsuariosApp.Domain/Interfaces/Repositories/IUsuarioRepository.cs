using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {

        void Add(Usuario usuario);

        Usuario? Get(string email, string senha);

        bool Any(string email);
    }
}
