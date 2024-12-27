using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class Categoria : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Concepto> Conceptos { get; set; }

        public Categoria() { }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new DatoInvalidoException("El nombre no puede estar vacio");
            if (string.IsNullOrEmpty(Descripcion))
                throw new DatoInvalidoException("La descripcion no puede estar vacia");
        }

        public void Copiar(Categoria categoria)
        {
            Nombre = categoria.Nombre;
            Descripcion = categoria.Descripcion;
            Conceptos = categoria.Conceptos;
        }
    }
}
