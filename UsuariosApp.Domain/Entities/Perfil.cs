namespace UsuariosApp.Domain.Entities
{
    /// <summary>
    /// Entidade de domínio para modelagem de perfil
    /// </summary>
    public class Perfil
    {

        #region Propriedades

        public Guid? Id { get; set; }
        public string? Nome { get; set; }

        #endregion

        #region Relacionamentos

        public List<Usuario>? Usuarios { get; set; }

        #endregion
    }
}