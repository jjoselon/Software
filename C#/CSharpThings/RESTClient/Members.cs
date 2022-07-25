using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace RESTClient
{
    [DataContract]
    class Members
    {
        [DataMember(Name = "name")]
        public string name;

        [DataMember(Name = "powers")]
        public string[] powers;
    }
}
