using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkRelationships.Entities
{
    class Tag
    {
        public int TagId { get; set; }

        public string Name { get; set; }

        /**
         * Navigation property ::> Reference navigation property
         * Referencia a una simple entidad
         * Navigation property ::> Inverse navigation property
         * También es una propiedad de navigacion inversa de Binnacle.Tags (y viceversa)
         */
        public Binnacle Binnacle { get; set; }

        /**
         * Si la entidad dependiente contiene una propiedad llamada 
         * 
         * <primary key property name>,
         * <navigation property name><primary key property name> o 
         * <principal entity name><primary key property name>
         * 
         * sera configurada como llave foranea
         * 
         * No foreign key property
         * 
         * Es recomendable tener una llave foranea en la clase dependiente, pero no es requerido.
         * 
         * Si ninguna porpiedad de llave foranea es encontrada, una shadow foreign key property 
         * sera introducida con el nombre de
         * <navigation property name><principal key property name>
         * ver Shadow properties para más información
         * 
         * 
         */
        public int BinnacleId { get; set; }

    }
}
