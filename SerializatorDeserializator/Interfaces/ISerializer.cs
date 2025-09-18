using System.Reflection;

namespace SerializatorDeserializator.Interfaces;

public interface ISerializer<T>
{
    public void SerializeList(List<T> listToSerialize);

    private Span<byte> SaveValues(T obj)
    {
        return null;
        
    }

    private Span<byte> SaveProperties()
    {
        return null;
    }

}