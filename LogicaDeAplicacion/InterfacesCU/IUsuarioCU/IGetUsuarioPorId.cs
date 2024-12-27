using Dto;

namespace LogicaDeAplicacion.InterfacesCU.IUsuarioCU
{
    public interface IGetUsuarioPorId
    {
        UsuarioDto Ejecutar(int id);
    }
}
