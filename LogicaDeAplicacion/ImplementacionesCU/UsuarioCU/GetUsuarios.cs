using Dto;
using LogicaDeNegocio.InterfacesRepositorios;
using LogicaDeNegocio.Entidades;
using LogicaDeAplicacion.InterfacesCU.IUsuarioCU;

namespace LogicaDeAplicacion.ImplementacionesCU.UsuarioCU
{
    public class GetUsuarios : IGetUsuarios
    {
        private readonly IRepositorioUsuario _repositorioUsuario;
        public GetUsuarios(IRepositorioUsuario repositorio)
        {
            _repositorioUsuario = repositorio;
        }
        public IEnumerable<UsuarioDto> Ejecutar()
        {
            List<UsuarioDto> usuariosDto = new List<UsuarioDto>();
            IEnumerable<Usuario> usuarios = _repositorioUsuario.GetUsuarios();

            foreach (Usuario u in usuarios)
                usuariosDto.Add(new UsuarioDto(u));

            return usuariosDto;
        }
    }
}
