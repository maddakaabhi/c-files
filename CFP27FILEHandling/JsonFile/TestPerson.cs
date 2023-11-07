using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace JsonFile
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int age { get; set; }
    }
    public class TestPerson
    {
        public void Test3()
        {
            Person x = new Person { Name = "Jason", Id = 101, age = 25 };
            // Convert the object to a JSON string
            string jsonString = JsonSerializer.Serialize(x);

            // Specify the file path
            string filePath = @"C:\\Users\\abhil\\Desktop\Person.json";

            // Write the JSON string to a file
            //File.WriteAllText(filePath, jsonString);

            //Console.WriteLine("JSON data written to file: " + filePath);

            //Reading all data in the filepath
            var output= File.ReadAllText(filePath);
            var person= JsonSerializer.Deserialize<Person>(output);
            Console.WriteLine("JSON data read from file:");
            Console.WriteLine($"First Name: {person.Name}");
            Console.WriteLine($"Id: {person.Id}");
            Console.WriteLine($"Age: {person.age}");
        
    }
    }
}

   
