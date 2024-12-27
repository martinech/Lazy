using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class Usuario : IValidable
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }
        public DateTime FechaAlta { get; set; }

        public Usuario() { }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Email))
                throw new DatoInvalidoException("El email no puede ser vacio");
            if (string.IsNullOrEmpty(Password))
                throw new DatoInvalidoException("La contraseña no puede ser vacia");
            if (string.IsNullOrEmpty(Rol))
                throw new DatoInvalidoException("El rol no puede estar vacio");
        }

        public void Copiar(Usuario usuario)
        {
            Email = usuario.Email;
            Password = usuario.Password;
            Rol = usuario.Rol;
        }
    }
}
