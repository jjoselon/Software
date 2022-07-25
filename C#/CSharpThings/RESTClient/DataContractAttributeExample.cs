using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System;

namespace RESTClient
{   
    [DataContract]
    class Persona : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataObjectValue;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataObjectValue;
            }
            set
            {
                extensionDataObjectValue = value;
            }
        }

        internal string Name;

        internal int ID;

        public Persona(string newName, int newID)
        {
            Name = newName;
            ID = newID;
        }
    }

}
