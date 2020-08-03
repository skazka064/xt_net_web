using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace myTest2
{    
    class Program
    {
        static void Main(string[] args)
        {
            var ship = new Spaceship() { Name = "Hunter", Damage = 150, Scores = new int[] { 5, 15, 45, 10 } };

            // Сериализация
            /*JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(@"c:\distrib\myJson.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, ship);
            }
            
            Console.WriteLine(JsonConvert.SerializeObject(ship));*/

            // Строковое представление
            var strObj = JsonConvert.SerializeObject(ship);
            // Десериализация
            var shipConverted = JsonConvert.DeserializeObject<Spaceship>(strObj);
        }
        public class Spaceship
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public int[] Scores { get; set; }
        }
    }
}
