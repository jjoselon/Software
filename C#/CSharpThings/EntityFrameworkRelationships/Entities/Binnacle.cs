using System.Collections.Generic;

namespace EntityFrameworkRelationships.Entities
{
    class Binnacle
    {
        public int BinnacleId { get; set; }

        public string Title { get; set; }


        /**
         * Navigation property ::> Collection navigation property
         * Contiene referencias a muchas entidades relacionadas
         * 
         * Una propiedad de navegación es considerada una propiedad de navegación si
         * el tipo al que apunta no puede ser mapeado como un tipo escalar por el actual
         * proveedor de base de datos.
         */
        public List<Tag> Tags { get; set; }


    }
}
