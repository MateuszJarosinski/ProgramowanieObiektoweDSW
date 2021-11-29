using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SerializacjaDeserializacjaDSW
{
    public class Engine
    {
        private int _cylinders = 1;
        public int Cylinders 
        {
            get
            {
                return _cylinders;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidEnumArgumentException("Height must be above 0");
                }
                else
                {
                    _cylinders = value;
                }
            }
        }

        private string _fuelTypel;

        public string FuelType
        {
            get
            {
                return _fuelTypel;
            }
            set
            {
                if (value != "benzyna" && value != "deasel")
                {
                    Console.WriteLine("Nieznany typ paliwa");
                }
                else
                {
                    _fuelTypel = value;
                }
            }
        }

        public Engine(int cylinders, string fuelType)
        {
            Cylinders = cylinders;
            FuelType = fuelType;
        }
    }
}