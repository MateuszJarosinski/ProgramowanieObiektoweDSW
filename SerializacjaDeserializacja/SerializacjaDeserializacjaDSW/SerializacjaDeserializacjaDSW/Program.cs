using System;

namespace SerializacjaDeserializacjaDSW
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine deasel20Tdi = new Engine(6, "deasel");
            Wheel[] fourWheels18Inches = new Wheel[4];
            for (int i = 0; i < 3; i++)
            {
                fourWheels18Inches[i] = new Wheel(true, true, true, 18);
            }
            
            Car AudiA48P = new Car("Audi", "A4B8", deasel20Tdi, fourWheels18Inches);
            
            Console.WriteLine(AudiA48P);
            
            Console.ReadLine();
        }
    }
}