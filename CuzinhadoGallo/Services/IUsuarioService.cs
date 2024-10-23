using CuzinhadoGallo.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace CuzinhadoGallo.Services;
public class IUsuarioService
{
    Task<USuarioVM> GetUsuarioLogado();
    Task<SignInResult> LoginUsuario(LoginVM login);
    Task<List<string>> RegistrarUsuario(RegistroVM registro);
    Task<bool> ConfirmarEmail(string userId, string code);
}