using System.Reflection;
using SerializatorDeserializator.Attributes;

namespace SerializatorDeserializator.Services;

public class Deserializer<T> : Interfaces.IDeserializer<T> where T : new() 
{
    public string filepath { get; set; }
    
    public Deserializer(string filepath)
    {
        this.filepath = filepath;
    }
    public List<T> Deserialize()
    {
        var objects = new List<T>();
        ReadOnlySpan<char> span = File.ReadAllText(filepath);
        
        while (!span.IsEmpty)
        {
            var endOfLineIndex = span.IndexOf('\n');
            if (endOfLineIndex == -1)
            {
                endOfLineIndex = span.Length;
            }

            var lineSpan = span.Slice(0, endOfLineIndex);
            if (!lineSpan.IsEmpty)
            {
                objects.Add(Parse(lineSpan));
            }

            span = span.Slice(endOfLineIndex + 1);
        }

        return objects;
    }

    private T Parse(ReadOnlySpan<char> line)
    {
        var obj = new T();
        var properties = typeof(T).GetProperties();

        var orderedProperties = properties.Where(p =>
        {
            var attribute = p.GetCustomAttribute<SerializeProperty>();
            return attribute != null;
        }).OrderBy(p => p.GetCustomAttribute<SerializationOrder>().Order).ToList();
        
        var remainingSpan = line;
        
        foreach (var property in orderedProperties)
        {
            var commaIndex = remainingSpan.IndexOf(',');
            var segment = commaIndex == -1 ? remainingSpan : remainingSpan.Slice(0, commaIndex);
            
            var colonIndex = segment.IndexOf(':');
            var valueSegment = colonIndex == -1 ? segment : segment.Slice(colonIndex + 1);
            var value = Convert.ChangeType(valueSegment.ToString(), property.PropertyType);
            property.SetValue(obj, value);
            
            if (commaIndex == -1) break;
            remainingSpan = remainingSpan.Slice(commaIndex + 1);
        }

        return obj;
    }
}