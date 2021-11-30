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
                    throw new InvalidEnumArgumentException("Cale muszą być wartościa dodatnią!");
                }
                else
                {
                    _cylinders = value;
                }
            }
        }

        private string _fuelType = "benzyna";

        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (value != "benzyna" && value != "deasel")
                {
                    throw new InvalidEnumArgumentException("Nieznany typ paliwa");
                }
                else
                {
                    _fuelType = value;
                }
            }
        }

        public Engine(int cylinders, string fuelType)
        {
            Cylinders = cylinders;
            FuelType = fuelType;
        }

        public Engine()
        {
            
        }

        public override string ToString()
        {
            return $"Silnik {_cylinders}-cylindrowy napędzany paliwem {_fuelType}";
        }
    }
}