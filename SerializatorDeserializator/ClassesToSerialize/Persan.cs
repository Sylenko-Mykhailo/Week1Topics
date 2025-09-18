﻿using SerializatorDeserializator.Attributes;
using SerializatorDeserializator.Services;

namespace SerializatorDeserializator.ClassesToSerialize;

public class Persan
{
    public Persan()
    {
        
    }
    public Persan(int id, string name, int age, string email, float? f, double d, bool b)
    {
        Id = id;
        Name = name;
        Age = age;
        Email = email;
        Float = f;
        Double = d;
        Bool = b;
    }

    [SerializeProperty] public int Id { get; private set; }


    [SerializeProperty] public string Name { get; set; }

    [SerializeProperty]public int Age { get; set; }

    [SerializeProperty] public string Email { get; set; }
    
    [SerializeProperty] public float? Float { get; set; }
    
    [SerializeProperty] public double Double { get; set; }
    [SerializeProperty] public bool Bool { get; set; }
    
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}, Email: {Email}, Float: {Float}, Double: {Double}, Bool: {Bool}";
    }
}