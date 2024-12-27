using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class Concepto: IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Concepto() { }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new DatoInvalidoException("El nombre no puede ser vacio");
        }

        public void Copiar(Etiqueta concepto)
        {
            Nombre = concepto.Nombre;
        }
    }
}
