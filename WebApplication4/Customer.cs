using System.Runtime.Serialization;
namespace WebApplication4
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name { get; set; }
    }
}