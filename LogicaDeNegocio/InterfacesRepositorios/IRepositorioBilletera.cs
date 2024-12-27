using LogicaDeNegocio.Entidades;

namespace LogicaDeNegocio.InterfacesRepositorios
{
    public interface IRepositorioBilletera
    {
        void Crear(Billetera billetera);
        IEnumerable<Billetera> GetBilleteras();
        Billetera GetBilleteraPorId(int id);
        void Modificar(int id, Billetera billetera);
        void Eliminar(int id);
    }
}
