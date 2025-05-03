using System.ComponentModel.DataAnnotations;

namespace UsuariosApp.Domain.Dtos
{
    public class CriarUsuarioRequest
    {
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string? Nome { get; set; }

        [EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$",
           ErrorMessage = "A senha deve conter no mínimo 8 caracteres, incluindo letra maiúscula, minúscula, número e caractere especial.")]
        public string? Senha { get; set; }

        [Compare("Senha", ErrorMessage = "Senhas não conferem, por favor verifique.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string? SenhaConfirmacao { get; set; }

    }
}
