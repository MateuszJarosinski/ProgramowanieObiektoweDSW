using System;
using System.ComponentModel;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SerializacjaDeserializacjaDSW
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            List<Car> carsToSerialize = new List<Car>();
            Engine deasel20Tdi = new Engine(6, "deasel");
            Wheel[] fourWheels18Inches = new Wheel[4];
            for (int i = 0; i < 3; i++)
            {
                fourWheels18Inches[i] = new Wheel(true, true, true, 18);
            }
            Wheel justNormalWheel = new Wheel(true, true, true, 18);
            Car AudiA48P = new Car("Audi", "A4B8", deasel20Tdi, fourWheels18Inches);
            creator.cars.Add(AudiA48P);
            creator.engines.Add(deasel20Tdi);
            creator.wheels.Add(justNormalWheel);



            carsToSerialize = creator.CreateObjects();
            Console.WriteLine("Czy chesz zapisać stworzone pojazdy? (TAK / NIE)");
            string serializeAnswer = Console.ReadLine();
            if (serializeAnswer.ToUpper() == "TAK")
            {
                SerializeCars(carsToSerialize);
            }
        }

        private static void SerializeCars(List<Car> carsToSerialize)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string serialize = JsonSerializer.Serialize(carsToSerialize ,options);
            System.IO.File.WriteAllText("cars.json", serialize);
        }
    }
}