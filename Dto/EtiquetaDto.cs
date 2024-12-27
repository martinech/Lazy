using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class EtiquetaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public EtiquetaDto() { }

        public EtiquetaDto(Etiqueta etiqueta)
        {
            Id = etiqueta.Id;
            Nombre = etiqueta.Nombre;
        }
        public Etiqueta ToEtiqueta()
        {
            Etiqueta etiqueta = new Etiqueta
            {
                Id = Id,
                Nombre = Nombre,
            };
            return etiqueta;
        }
    }
}
