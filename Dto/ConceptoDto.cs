using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;

namespace LogicaDeNegocio.Entidades
{
    public class ConceptoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ConceptoDto() { }

        public ConceptoDto(Concepto concepto)
        {
            Id = concepto.Id;
            Nombre = concepto.Nombre;
        }

        public Concepto ToConcepto()
        {
            Concepto concepto = new Concepto()
            {
                Id = Id,
                Nombre = Nombre
            };
            return concepto;
        }
    }
}
