using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class Movimiento : IValidable
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int IdBilleteraOrigen { get; set; }
        public int? IdBilleteraDestino { get; set; }
        public string Descripcion { get; set; }
        public int IdConcepto { get; set; }
        public int IdCategoria { get; set; }
        public int IdEtiqueta { get; set; }

        public Movimiento() { }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Tipo))
                throw new DatoInvalidoException("El email no puede ser vacio");
            if (Monto == 0)
                throw new DatoInvalidoException("La contraseña no puede ser vacia");
            if (Fecha == DateTime.MinValue)
                throw new DatoInvalidoException("El rol no puede estar vacio");
            if (IdBilleteraOrigen == null)
                throw new DatoInvalidoException("El rol no puede estar vacio");
            if (string.IsNullOrEmpty(Descripcion))
                throw new DatoInvalidoException("El rol no puede estar vacio");
            if (IdConcepto == null)
                throw new DatoInvalidoException("El rol no puede estar vacio");
            if (IdCategoria == null)
                throw new DatoInvalidoException("El rol no puede estar vacio");
            if (IdEtiqueta == null)
                throw new DatoInvalidoException("El rol no puede estar vacio");
        }

        public void Copiar(Movimiento movimiento)
        {
            Tipo = movimiento.Tipo;
            Monto = movimiento.Monto;
            Fecha = movimiento.Fecha;
            IdBilleteraOrigen = movimiento.IdBilleteraOrigen;
            IdBilleteraOrigen = movimiento.IdBilleteraOrigen;
            Descripcion = movimiento.Descripcion;
            IdConcepto = movimiento.IdConcepto;
            IdCategoria = movimiento.IdCategoria;
            IdEtiqueta = movimiento.IdEtiqueta;
        }
    }
}
