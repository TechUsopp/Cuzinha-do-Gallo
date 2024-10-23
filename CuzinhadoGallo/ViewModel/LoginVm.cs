using System.ComponentModel.DataAnnotations;

namespace CuzinhadoGallo.ViewModel

public class LoginVm
{
    [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu Email ou nome de usuário")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "********")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    [DataType(DataType.PassWord)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; }

    public string UrlRetorno { get; set; }
}