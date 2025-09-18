namespace SerializatorDeserializator.Interfaces;

public interface IDeserializer<T> where T : new()
{
    public List<T> DeserializeList();

    private List<(string name, Type type)> ReadProperties(FileStream fs)
    {
        return null;
    }

    private T ReadValues(FileStream fs, List<(string name, Type type)> propertiesInfo)
    {
        return default;
    }
}