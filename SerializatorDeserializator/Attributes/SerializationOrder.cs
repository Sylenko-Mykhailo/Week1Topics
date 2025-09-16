namespace SerializatorDeserializator.Attributes;

public class SerializationOrder : Attribute
{
    public int Order { get; set; }
    public SerializationOrder(int order)
    {
        Order = order;
    }
}