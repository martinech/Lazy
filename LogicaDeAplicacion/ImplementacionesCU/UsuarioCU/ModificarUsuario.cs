using LogicaDeNegocio.InterfacesRepositorios;
using Dto;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.Exceptions;
using LogicaDeAplicacion.InterfacesCU.IUsuarioCU;

namespace LogicaDeAplicacion.ImplementacionesCU.UsuarioCU
{
    public class ModificarUsuario : IModificarUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public ModificarUsuario(IRepositorioUsuario repositorio)
        {
            _repositorioUsuario = repositorio;
        }

        public void Ejecutar(int id, UsuarioDto usuarioDto)
        {
            Usuario usuario = usuarioDto.ToUsuario();

            try
            {
                usuario.Validar();
                _repositorioUsuario.Modificar(id, usuario);
            }
            catch (DatoInvalidoException e)
            {
                throw;
            }
        }
    }
}
