using Dto;
namespace LogicaDeAplicacion.InterfacesCU.IUsuarioCU
{
    public interface IGetUsuarios
    {
        IEnumerable<UsuarioDto> Ejecutar();
    }
}
