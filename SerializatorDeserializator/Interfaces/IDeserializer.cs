namespace SerializatorDeserializator.Interfaces;

public interface IDeserializer<T> where T : new()
{
    public List<T> Deserialize();

    private T Parse(ReadOnlySpan<char> line)
    {
        return new T();
    }


}