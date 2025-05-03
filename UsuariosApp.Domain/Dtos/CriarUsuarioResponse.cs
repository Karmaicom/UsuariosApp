using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Domain.Dtos
{
    public class CriarUsuarioResponse
    {

        public string? Mensagem { get; set; }
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int MyProperty { get; set; }

    }
}
