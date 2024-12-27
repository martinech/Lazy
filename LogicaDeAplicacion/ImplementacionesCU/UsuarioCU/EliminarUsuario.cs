using LogicaDeAplicacion.InterfacesCU.IUsuarioCU;
using LogicaDeNegocio.InterfacesRepositorios;

namespace LogicaDeAplicacion.ImplementacionesCU.UsuarioCU
{
    public class EliminarUsuario : IEliminarUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public EliminarUsuario(IRepositorioUsuario repositorio)
        {
            _repositorioUsuario = repositorio;
        }

        public void Ejecutar(int id)
        {
            _repositorioUsuario.Eliminar(id);
        }
    }
}
