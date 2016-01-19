using System.Runtime.Serialization;

namespace BeersApi.Entities
{
    [DataContract]
    public class Beer
    {
        [DataMember]
        public string Brewery { get; private set; }

        [DataMember]
        public string Name { get; private set; }

        public Beer(string brewery, string name)
        {
            Brewery = brewery;
            Name = name;
        }
    }
}