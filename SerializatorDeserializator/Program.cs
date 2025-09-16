
using SerializatorDeserializator.ClassesToSerialize;
using SerializatorDeserializator.Services;



// var list = new List<Person>()
// {
//     new Person { Id = 1, Name = "Alice", Age = 20, Email = "dbcjds@ven.com" },
//     new Person {Id = 2, Name = "Bob", Age = 25, Email = "dbcjds@gmail.com"}
// };
// var serializer = new Serializer<Person>("people.txt");
// serializer.Serialize(list);

var deserializer = new Deserializer<Person>("people.txt");
var deserializedList = deserializer.Deserialize();
foreach (var person in deserializedList)
{
    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}, Email: {person.Email}");
}