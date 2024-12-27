using LogicaDeNegocio.Entidades;

namespace Dto
{
    public class MovimientoDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int IdBilleteraOrigenDto { get; set; }
        public int? IdBilleteraDestinoDto { get; set; }
        public string Descripcion { get; set; }
        public int IdConcepto { get; set; }
        public int IdCategoria { get; set; }
        public int IdEtiqueta { get; set; }

        public MovimientoDto() { }

        public MovimientoDto(Movimiento movimiento)
        {
            Id = movimiento.Id;
            Tipo = movimiento.Tipo;
            Monto = movimiento.Monto;
            Fecha = movimiento.Fecha;
            IdBilleteraOrigenDto = movimiento.IdBilleteraOrigen;
            IdBilleteraDestinoDto = movimiento.IdBilleteraDestino;
            Descripcion = movimiento.Descripcion;
            IdConcepto = movimiento.IdConcepto;
            IdCategoria = movimiento.IdCategoria;
            IdEtiqueta = movimiento.IdEtiqueta;
        }

        public Movimiento ToMovimiento()
        {
            Movimiento movimiento = new Movimiento()
            {
                Id = Id,
                Tipo = Tipo,
                Monto = Monto,
                Fecha = Fecha,
                IdBilleteraOrigen = IdBilleteraOrigenDto,
                IdBilleteraDestino = IdBilleteraDestinoDto,
                Descripcion = Descripcion,
                IdConcepto = IdConcepto,
                IdCategoria = IdCategoria,
                IdEtiqueta = IdEtiqueta
            };
            return movimiento;
        }
    }
}
