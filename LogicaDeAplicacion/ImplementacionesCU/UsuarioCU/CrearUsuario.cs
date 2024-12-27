using Dto;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.Exceptions;
using LogicaDeNegocio.InterfacesRepositorios;
using LogicaDeAplicacion.InterfacesCU.IUsuarioCU;

namespace LogicaDeAplicacion.ImplementacionesCU.UsuarioCU
{
    public class CrearUsuario : ICrearUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public CrearUsuario(IRepositorioUsuario repositorio)
        {
            _repositorioUsuario = repositorio;
        }
        public void Ejecutar(UsuarioDto usuarioDto)
        {
            IEnumerable<Usuario> usuariosExistentes = _repositorioUsuario.GetUsuarios();
            if (usuariosExistentes.Any(u => u.Email.Equals(usuarioDto.Email)))
            {
                throw new DatoInvalidoException("Ya existe un usuario con ese nombre.");
            }
            else
            {
                Usuario usuarioNuevo = usuarioDto.ToUsuario();
                usuarioNuevo.Validar();
                _repositorioUsuario.Crear(usuarioNuevo);
            }
        }
    }
}
