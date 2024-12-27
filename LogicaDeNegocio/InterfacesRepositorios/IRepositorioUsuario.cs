using LogicaDeNegocio.Entidades;

namespace LogicaDeNegocio.InterfacesRepositorios
{
    public interface IRepositorioUsuario
    {
        void Crear(Usuario usuario);
        IEnumerable<Usuario> GetUsuarios();
        Usuario GetUsuarioPorId(int id);
        void Modificar(int id, Usuario usuario);
        void Eliminar(int id);
        Usuario Login(string email, string password);
    }
}
