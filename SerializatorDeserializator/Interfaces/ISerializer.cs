using System.Reflection;

namespace SerializatorDeserializator.Interfaces;

public interface ISerializer<T>
{
    void Serialize(List<T> objects);

    private int Stringify(T obj, Span<char> span)
    {
        return 0;
    }

    private int CreateSpan(PropertyInfo prop, T obj, Span<char> span, ref int position)
    {
        return 0;
    }


}