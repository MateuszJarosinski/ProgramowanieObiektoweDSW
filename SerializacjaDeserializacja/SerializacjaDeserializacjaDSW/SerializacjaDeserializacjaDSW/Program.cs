using System;
using System.Text.Json;
using System.Collections.Generic;

namespace SerializacjaDeserializacjaDSW
{
    class Program
    {
        static void Main(string[] args)
        {
            //twprzenie podstawowych obiektów tak aby program nie rozpoczynał się bez obiektów
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
            
            //dodaje pierwsze obiekty do list kreatora
            creator.cars.Add(AudiA48P);
            creator.engines.Add(deasel20Tdi);
            creator.wheels.Add(justNormalWheel);
            
            
            //TU ZACZYNA SIĘ WŁAŚCIWY PROGRAM
            Console.WriteLine("Stwórz swój pojazd: ");
            carsToSerialize = creator.CreateObjects();
            Console.WriteLine("Czy chesz zapisać stworzone pojazdy? (TAK / NIE)");
            string serializeAnswer = Console.ReadLine();
            if (serializeAnswer.ToUpper() == "TAK")
            {
                SerializeCars(carsToSerialize);
            }
            
            Console.WriteLine("Czy chesz odczytać zapisane obiekty? (TAK / NIE)");
            string deserializationAnswer = Console.ReadLine();
            if (deserializationAnswer.ToUpper() == "TAK")
            {
                DeserializeCars();
            }
        }

        private static void SerializeCars(List<Car> carsToSerialize)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                string serialize = JsonSerializer.Serialize(carsToSerialize ,options);
                System.IO.File.WriteAllText("cars.json", serialize);
                Console.WriteLine("Serializacja wykonana pomyślnie");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void DeserializeCars()
        {
            try
            {
                string deserialised = System.IO.File.ReadAllText("cars.json");
                List<Car> deserialisedCars = JsonSerializer.Deserialize<List<Car>>(deserialised);
                foreach (Car car in deserialisedCars)
                {
                    Console.WriteLine(car);
                }
                Console.WriteLine("Deserializacja wykonana pomyślnie");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}