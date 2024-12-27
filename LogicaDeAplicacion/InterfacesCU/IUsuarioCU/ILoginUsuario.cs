using Dto;

namespace LogicaDeAplicacion.InterfacesCU.IUsuarioCU
{
    public interface ILoginUsuario
    {
        UsuarioDto Ejecutar(string email, string password);
    }
}
