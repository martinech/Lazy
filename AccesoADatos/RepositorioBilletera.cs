using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;

namespace AccesoADatos
{
    public class RepositorioBilletera : IRepositorioBilletera
    {
        private DbContext _contexto;

        public RepositorioBilletera(DbContext contexto)
        {
            _contexto = contexto;
        }

        public void Crear(Billetera billetera)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Billetera GetBilleteraPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Billetera> GetBilleteras()
        {
            throw new NotImplementedException();
        }

        public void Modificar(int id, Billetera billetera)
        {
            throw new NotImplementedException();
        }
    }
}
