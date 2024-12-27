using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class Billetera : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Moneda { get; set; }
        public decimal SaldoActual { get; set; }
        public List<Movimiento> Movimientos { get; set; }

        public Billetera() { }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new DatoInvalidoException("El nombre no puede estar vacio");
            if (string.IsNullOrEmpty(Moneda))
                throw new DatoInvalidoException("La moneda no puede estar vacia");
        }

        public void Copiar(Billetera billetera)
        {
            Nombre = billetera.Nombre;
            Moneda = billetera.Moneda;
            SaldoActual = billetera.SaldoActual;
        }
    }
}
