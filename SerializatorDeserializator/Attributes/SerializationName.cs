namespace SerializatorDeserializator.Attributes;

public class SerializationName : Attribute
{
    public string Name { get; set; }
    public SerializationName(string name)
    {
        Name = name;
    }
}