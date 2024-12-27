using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.Exceptions;
using LogicaDeNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;

namespace AccesoADatos
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private DbContext _contexto;

        public RepositorioUsuario(DbContext contexto)
        {
            _contexto = contexto;
        }

        public Usuario Login(string email, string password)
        {
            return _contexto.Set<Usuario>().FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public void Crear(Usuario usuario)
        {
            if (_contexto.Set<Usuario>().Any(u => u.Email == usuario.Email))
                throw new DatoInvalidoException("Ya existe un usuario con este email");
            else
            {
                _contexto.Set<Usuario>().Add(usuario);
                _contexto.SaveChanges();
            }
        }

        public Usuario GetUsuarioPorId(int id)
        {
            return _contexto.Set<Usuario>().FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _contexto.Set<Usuario>().ToList();
        }

        public void Modificar(int id, Usuario usuario)
        {
            Usuario UsuarioAModificar = _contexto.Set<Usuario>().FirstOrDefault(t => t.Id == id);
            UsuarioAModificar.Copiar(usuario);
            _contexto.Entry(UsuarioAModificar).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Usuario usuarioAEliminar = _contexto.Set<Usuario>().FirstOrDefault(t => t.Id == id);
            _contexto.Set<Usuario>().Remove(usuarioAEliminar);
            _contexto.SaveChanges();
        }
    }
}
