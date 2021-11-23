using System;
using System.Runtime.InteropServices;

namespace SerializacjaDeserializacjaDSW
{
    public class Engine
    {
        private int _cylinders;
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
                    value *= -1;
                    _cylinders = value;
                }
                else
                {
                    value = _cylinders;
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
                if (value != "benzyna" || value != "deasel")
                {
                    Console.WriteLine("Nieznany typ paliwa");
                }
                else
                {
                    _fuelTypel = value;
                }
            }
        }
    }
}