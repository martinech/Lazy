using LogicaDeNegocio.Entidades;

namespace Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }
        public DateTime FechaAlta { get; set; }
        public string token { get; set; }

        public UsuarioDto() { }

        public UsuarioDto(Usuario usuario)
        {
            Id = usuario.Id;
            Email = usuario.Email;
            Password = usuario.Password;
            Nombre = usuario.Nombre;
            Apellido = usuario.Apellido;
            Rol = usuario.Rol;
            FechaAlta = usuario.FechaAlta;
        }

        public Usuario ToUsuario()
        {
            Usuario usuario = new Usuario()
            {
                Id = Id,
                Email = Email,
                Password = Password,
                Nombre = Nombre,
                Apellido = Apellido,
                Rol = Rol,
                FechaAlta = FechaAlta
            };
            return usuario;
        }
    }
}
