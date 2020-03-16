using System;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
           // in .Net, for XML serialization, we have 
           // -DataContractSerializer
           // -XMLSerializer (old, non-generic)
           // for JSON serialization, we have
           // -JSON.NET aka Newtonsoft JSON

           string filePath = "../../../data.json";
           if(!filePath.Exists(filePath))
           {
               List<Person> data
           }

           var data = GetInitialData();

           string json = ConvertToJson(data);

            WriteToFile(json);
        }

        private static void WriteToFile(string text)
        {
            var file = new FileStream(path, FileMode.Create);
            byte[] data = Encoding.UTF8.GetBytes(text);

            file.Write(data);

            file.Close();
        }

        static string ConvertToJson(List<Person> data)
        {
            return JsonSerializer.Serialize(data);
    
        }

        static List<Person> GetInitialData()
        {
            var list = new List<Person>();
            var person1 = new Person();
            nick.Id = 1;
            nick.Name = "Nick";

            var person2 = new Person();
            mark.Id = 2;
            mark.Name = "Mark";
            mark.Children = new List<Person>
            {
                new Person {Id = 3, Name = "Ethan"},
                new Person {Id = 4, Name = "Hope"},
                new Person {Id = 5, Name = "Maya"}
            };

            list.Add(nick);
            list.Add(mark);
            return list;
        }
    }
}
