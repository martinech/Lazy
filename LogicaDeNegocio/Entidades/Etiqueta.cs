using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class Etiqueta : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Etiqueta() { }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new DatoInvalidoException("El nombre no puede estar vacio");
        }

        public void Copiar(Usuario usuario)
        {
            Nombre = usuario.Nombre;
        }
    }
}
