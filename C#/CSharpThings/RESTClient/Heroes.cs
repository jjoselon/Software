using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

/**
 * Esta clase demuestra otra caracteristica de la serialización y deserealización JSON
 * 
 * El serializador de JSON ignorara los campos que no se encuentren en la clase, lo que permite
 * trabajar unicamente con un conjunto de datos necesarios
 */
namespace RESTClient
{
    [DataContract]
    class Heroes
    {
        [DataMember(Name = "squadName")]
        public string squadName;

        [DataMember(Name = "homeTown")]
        public string homeTown;

        [DataMember(Name = "members")]
        public List<Members> members;
    }
}
