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
        ReadOnlySpan<char> span;
        try
        {
            span = File.ReadAllText(filepath).AsSpan();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return objects;
        }
        
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

        var propertiesToSerialize = properties.Where(p =>
        {
            var isToSerialize = p.GetCustomAttribute<SerializeProperty>();
            return isToSerialize != null;
        }).ToList();
        
        var orderedProperties = propertiesToSerialize.OrderBy(p =>
        {
            var orderAttribute = p.GetCustomAttribute<SerializationOrder>();
            return orderAttribute?.Order ?? int.MaxValue;
        }).ToList();
        
        var remainingSpan = line;
        
        foreach (var property in orderedProperties)
        {
            var commaIndex = remainingSpan.IndexOf(',');
            var segment = commaIndex == -1 ? remainingSpan : remainingSpan.Slice(0, commaIndex);
            
            var colonIndex = segment.IndexOf(':');
            if (colonIndex == -1)
            {
                Console.WriteLine($"No ':' for property {property.Name}");
                if (commaIndex == -1) break;
                remainingSpan = remainingSpan.Slice(commaIndex + 1);
                continue;
            }
            var valueSegment = segment.Slice(colonIndex + 1);
            try
            {
                var value = Convert.ChangeType(valueSegment.ToString(), property.PropertyType);
                property.SetValue(obj, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($" impossible to deserialize '{valueSegment}' for property {property.Name}: {ex.Message}");
            }
            
            if (commaIndex == -1) break;
            remainingSpan = remainingSpan.Slice(commaIndex + 1);
        }

        return obj;
    }
}