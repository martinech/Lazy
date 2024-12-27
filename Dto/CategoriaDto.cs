using LogicaDeNegocio.InterfacesEntidades;
using LogicaDeNegocio.Exceptions;
using Dto;

namespace LogicaDeNegocio.Entidades
{
    public class CategoriaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<ConceptoDto> ConceptosDto { get; set; }

        public CategoriaDto() { }

        public CategoriaDto(Categoria categoria)
        {
            Id = categoria.Id;
            Nombre = categoria.Nombre;
            Descripcion = categoria.Descripcion;
            ConceptosDto = ConceptosAConceptosDto(categoria.Conceptos);
        }

        public Categoria ToCategoria()
        {
            Categoria categoria = new Categoria()
            {
                Id = Id,
                Nombre = Nombre,
                Descripcion = Descripcion
            };

            return categoria;
        }
        public List<Concepto> ConceptosDtoAConceptos()
        {
            List<Concepto> conceptos = new List<Concepto>();

            foreach (ConceptoDto conceptoDto in ConceptosDto)
            {
                conceptos.Add(new Concepto()
                {
                    Id = conceptoDto.Id,
                    Nombre = conceptoDto.Nombre
                });
            }

            return conceptos;
        }

        public List<ConceptoDto> ConceptosAConceptosDto(List<Concepto> conceptos)
        {
            List<ConceptoDto> conceptosDto = new List<ConceptoDto>();

            foreach (Concepto concepto in conceptos)
            {
                conceptosDto.Add(new ConceptoDto(concepto));
            }
            return conceptosDto;

        }
    }
}
