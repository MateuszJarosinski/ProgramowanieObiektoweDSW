using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace SerializacjaDeserializacjaDSW 
{
    public class Creator
    {
        public List<Engine> engines = new List<Engine>();
        public List<Wheel> wheels = new List<Wheel>();
        public List<Car> cars = new List<Car>();
        private string answer = "TAK";
        
        public List<Car> CreateObjects()
            {
                while (answer.ToUpper() == "TAK")
                {
                    Console.WriteLine("Co chcesz zrobić?");
                    string choice = Console.ReadLine().ToUpper();
                    switch (choice)
                    {
                        case "SILNIK":
                            CreateEngine();
                            break;
                        case "KOLO":
                            CreateWheel();
                            break;
                        case "AUTO":
                            CreateCar();
                            break;
                        default:
                            throw new InvalidEnumArgumentException("Nieznana opcja");
                    }
                    
                    Console.WriteLine("Czy chesz zrobić coś jeszcze? (TAK / NIE)");
                    answer = Console.ReadLine();
                }
                return cars;
            }
        public void CreateCar()
            {
                Console.WriteLine("Tworzenie pojazdu:");
                Console.WriteLine("Podaj markę:");
                string answerBrand = Console.ReadLine();
                Console.WriteLine("Podaj model");
                string answserModel = Console.ReadLine();
                Console.WriteLine("Wybierz silnik: (index 0/1/2/3...)");
                ShowEngines();
                Engine answerEngine = ChooseEngine();
                Console.WriteLine("Wybierz koła: ");
                ShowWheels();
                Wheel answerWheel = ChooseWheel();
                Wheel[] fourWheelsArray = new Wheel[4];
                for (int i = 0; i < 4; i++)
                {
                    fourWheelsArray[i] = answerWheel;
                }
                Car createdCar = new Car(answerBrand, answserModel, answerEngine, fourWheelsArray);
                Console.WriteLine(createdCar.ToString());
                cars.Add(createdCar);
            }

            public void CreateWheel()
            {
                Console.WriteLine("Tworzenie koła: ");
                Console.WriteLine("Czy to koło napędza samochód? (true / false)");
                bool answerPower = Boolean.Parse(Console.ReadLine());
                Console.WriteLine("Czy to koło steruje autem? (true / false)");
                bool answerSteer = Boolean.Parse(Console.ReadLine());
                Console.WriteLine("Czy to kołó hamuje pojazd?");
                bool answerBrake = Boolean.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ilość cali koła: ");
                int answerInches = Int32.Parse(Console.ReadLine());

                Wheel wheel = new Wheel(answerSteer, answerPower, answerBrake, answerInches);
                wheels.Add(wheel);
                
            }

            public void CreateEngine()
            {
                Console.WriteLine("Tworzenie silnika: ");
                Console.WriteLine("Podaj ilość cylindfrów (więcej niż 0!)");
                int cylinder = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj rodzaj paliwa: (deasel, benzyna)");
                string fuelType = Console.ReadLine();

                Engine engine = new Engine(cylinder, fuelType);
                engines.Add(engine);
            }

            private void ShowEngines()
            {
                for (int i = 0; i < engines.Count; i++)
                {
                    Console.WriteLine(engines[i].ToString());
                }
            }

            private Engine ChooseEngine()
            {
                int index = Int32.Parse(Console.ReadLine());
                Engine choosenEngine = engines[index];
                return choosenEngine;
            }

            private void ShowWheels()
            {
                for (int i = 0; i < wheels.Count; i++)
                {
                    Console.WriteLine(wheels[i].ToString());
                }
            }
            
            private Wheel ChooseWheel()
            {
                int index = Int32.Parse(Console.ReadLine());
                Wheel choosenWheel = wheels[index];
                return choosenWheel;
            }
    }
}