using SerializatorDeserializator.Attributes;

namespace SerializatorDeserializator.ClassesToSerialize;

public class Person
{
    [SerializeProperty]
    [SerializationOrder(0)]
    public int Id { get; set; }
    
    [SerializeProperty]
    [SerializationOrder(1)]
    public string Name { get; set; }
    
    public int Age { get; set; }
    
    [SerializeProperty]
    [SerializationOrder(2)]
    [SerializationName("email_address")]
    public string Email { get; set; }
    
}