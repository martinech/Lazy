using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;
using Dto;

namespace LogicaDeNegocio.Entidades
{
    public class BilleteraDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Moneda { get; set; }
        public decimal SaldoActual { get; set; }
        public List<MovimientoDto> MovimientosDto { get; set; }

        public BilleteraDto() { }

        public BilleteraDto(Billetera billetera)
        {
            Nombre = billetera.Nombre;
            Moneda = billetera.Moneda;
            SaldoActual = billetera.SaldoActual;
            MovimientosDto = MovimientosAMovimientosDto(billetera.Movimientos);
        }

        public Billetera ToBilletera()
        {
            Billetera billetera = new Billetera()
            {
                Id = Id,
                Nombre = Nombre,
                Moneda = Moneda,
                SaldoActual = SaldoActual,
                Movimientos = MovimientosDtoAMovimientos()
            };
            return billetera;
        }

        public List<Movimiento> MovimientosDtoAMovimientos()
        {
            List<Movimiento> movimientos = new List<Movimiento>();

            foreach(MovimientoDto movimientoDto in MovimientosDto)
            {
                movimientos.Add(new Movimiento()
                {
                    Tipo = movimientoDto.Tipo,
                    Monto = movimientoDto.Monto,
                    Fecha = movimientoDto.Fecha,
                    IdBilleteraOrigen = movimientoDto.IdBilleteraOrigenDto,
                    IdBilleteraDestino = movimientoDto.IdBilleteraDestinoDto,
                    Descripcion = movimientoDto.Descripcion,
                    IdConcepto = movimientoDto.IdConcepto,
                    IdCategoria = movimientoDto.IdCategoria,
                    IdEtiqueta = movimientoDto.IdEtiqueta
                });
            }

            return movimientos;
        }

        public List<MovimientoDto> MovimientosAMovimientosDto(List<Movimiento> movimientos)
        {
            List<MovimientoDto> movimientosDto = new List<MovimientoDto>();

            foreach (Movimiento movimiento in movimientos)
            {
                movimientosDto.Add(new MovimientoDto(movimiento));
            }


            return movimientosDto;

        }
    }

}
