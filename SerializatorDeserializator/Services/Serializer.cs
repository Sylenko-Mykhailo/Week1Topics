﻿using System.Reflection;
using System.Text;

using SerializatorDeserializator.Attributes;

namespace SerializatorDeserializator.Services;

public class Serializer<T> : Interfaces.ISerializer<T>
{
    public string filePath { get; set; }

    public Serializer(string filePath)
    {
        this.filePath = filePath;
    }

    public void Serialize(List<T> objects)
    {
        var stringBuilder = new StringBuilder();
        
        char[] tempBuffer = new char[1024]; 
    
        foreach (var obj in objects)
        {
            Span<char> buffer = tempBuffer.AsSpan();
        
            var charsWritten = Stringify(obj, buffer);
            
            stringBuilder.Append(buffer[..charsWritten]);
            stringBuilder.AppendLine();
        }
    
        File.WriteAllText(filePath, stringBuilder.ToString());
    }

    private int Stringify(T obj, Span<char> span)
    {
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
        var value = prop.GetValue(obj)?.ToString() ?? string.Empty; 

        if (position + name.Length + 1 > span.Length)
        {
            throw new InvalidOperationException("Buffer too small for serializing property name.");
        }
    
        name.CopyTo(span.Slice(position));
        position += name.Length;

        span[position++] = ':';

        if (position + value.Length > span.Length)
        {
            throw new InvalidOperationException("Buffer too small for serializing property value.");
        }
    
        value.CopyTo(span.Slice(position));
        position += value.Length;
    
        return name.Length + 1 + value.Length;
    }
}