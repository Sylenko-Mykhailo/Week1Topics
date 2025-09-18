using SerializatorDeserializator.ClassesToSerialize;
using SerializatorDeserializator.Services;

var list = new List<Person>
{
    new Person( 1, "Alice", 30, "dcdqaCDC", float.Floor(1.23f), Double.E, true),
    null,
    new Person( 2, "Bob", 25, "qweqwe", 1.25f, Double.NaN, false),
};

// // Null value
// var serializer = new Serializer<Person>("people.bin");
// serializer.SerializeList(list);
//
// var deserializer = new Deserializer<Person>("people.bin");
// var deserializedList = deserializer.DeserializeList();
// foreach (var person in deserializedList)
// {
//     Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Email: {person.Email}");
// }

var serializer = new Serializer<Person>("people.bin", new Logger());
serializer.SerializeList(list);

var deserializer = new Deserializer<Persan>("people.bin", new Logger());
var deserializedList = deserializer.DeserializeList();
foreach (var person in deserializedList)
    Console.WriteLine(person.ToString());