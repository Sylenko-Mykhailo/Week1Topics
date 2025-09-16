using System.Reflection;
using System.Text;
using SerializatorDeserializator.Attributes;

namespace SerializatorDeserializator.Services;

public class Serializer<T>
{
    public string filePath { get; set; }

    public Serializer(string filePath)
    {
        this.filePath = filePath;
    }

    public void Serialize(List<T> objects)
    {
        var stringBuilder = new StringBuilder();

        foreach (var obj in objects)
        {
            Span<char> span = stackalloc char[128]; 

            var charsWritten = Stringify(obj, span);
            stringBuilder.AppendLine(new string(span[..charsWritten]));
        }
        File.WriteAllText(filePath, stringBuilder.ToString());
    }

    private int Stringify(T obj, Span<char> span)
    {
        var properties = typeof(T).GetProperties();
        
        var orderedProperties = properties.Where(p =>
        {
            var attribute = p.GetCustomAttribute<SerializeProperty>();
            return attribute != null;
        }).OrderBy(p => p.GetCustomAttribute<SerializationOrder>().Order).ToList();
        
        int position = 0;
        
        foreach (var property in orderedProperties)
        {
            position += CreateSpan(property, obj, span, ref position);

            if (position < span.Length)
            {
                span[position++] = ',';
            }
        }
        return position - 1;
    }
    
    private int CreateSpan(PropertyInfo prop, T obj, Span<char> span, ref int position)
    {
        var attribute = prop.GetCustomAttribute<SerializationName>();
        var name = attribute != null ? attribute.Name : prop.Name;
        var value = prop.GetValue(obj)?.ToString();
    
        name.CopyTo(span.Slice(position));
        
        position += name.Length;
    
        span[position++] = ':';

        if (value != null)
        {
            value.CopyTo(span.Slice(position));
            position += value.Length;
        }
        return name.Length + 1 + (value?.Length ?? 0);
    }
}