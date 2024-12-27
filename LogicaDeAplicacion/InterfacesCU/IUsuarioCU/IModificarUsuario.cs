using Dto;

namespace LogicaDeAplicacion.InterfacesCU.IUsuarioCU
{
    public interface IModificarUsuario
    {
        void Ejecutar(int id, UsuarioDto usuarioDto);
    }
}
