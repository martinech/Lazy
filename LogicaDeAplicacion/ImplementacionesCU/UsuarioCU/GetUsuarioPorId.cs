using Dto;
using LogicaDeAplicacion.InterfacesCU.IUsuarioCU;
using LogicaDeNegocio.Exceptions;
using LogicaDeNegocio.InterfacesRepositorios;
using LogicaDeNegocio.Entidades;

namespace LogicaDeAplicacion.ImplementacionesCU.UsuarioCU
{
    public class GetUsuarioPorId : IGetUsuarioPorId
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public GetUsuarioPorId(IRepositorioUsuario repositorio)
        {
            _repositorioUsuario = repositorio;
        }
        public UsuarioDto Ejecutar(int id)
        {
            Usuario usuario = _repositorioUsuario.GetUsuarioPorId(id);
            if (usuario is not null)
            {
                UsuarioDto usuarioDto = new UsuarioDto(usuario);
                return usuarioDto;
            }
            else
                throw new UsuarioInvalidoException("Operacion invalida");
        }
    }
}
