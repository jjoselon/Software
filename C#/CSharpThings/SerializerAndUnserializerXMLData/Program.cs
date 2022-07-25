using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System;

namespace SerializerAndUnserializerXMLData
{

    [DataContract(Name = "Customer", Namespace = "http://www.contoso.com")]
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

        [DataMember(Name = "CustName")]
        internal string Name;

        [DataMember(Name = "CustID")]
        internal int ID;

        public Persona(string newName, int newID)
        {
            Name = newName;
            ID = newID;
        }
    }

    class XMLSerializerAndUnserializer
    {
        static void Main(string[] args)
        {
            try
            {
                WriteObject("C:\\Users\\jjose\\Desktop\\file.xml");
                Console.WriteLine("Press Enter to end");
                Console.ReadLine();
            } catch (SerializationException se)
            {
                Console.WriteLine("The serialization operation failed. Reason: {0}", se.Message);
                Console.WriteLine(se.Data);
                Console.ReadLine();
            }
        }

        public static void WriteObject(string path)
        {
            Persona p1 = new Persona("José", 1);
            FileStream fs = new FileStream(path, FileMode.Create);

            XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(fs);
            DataContractSerializer serializer = new DataContractSerializer(typeof(Persona));

            serializer.WriteObject(writer, p1);
            Console.WriteLine("Finished writing object");
            writer.Close();
            fs.Close();

        }

        public static void ReadObject(string path)
        {
            Persona p1 = new Persona("Jose", 10);

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

            DataContractSerializer serializer = new DataContractSerializer(typeof(Persona));

            Persona newPersona = (Persona)serializer.ReadObject(reader);
        }
    }

}
