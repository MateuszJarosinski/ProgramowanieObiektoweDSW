using System.Security.Principal;

namespace SerializacjaDeserializacjaDSW
{
    public class Car
    {
        public string _brand { get; set; }
        public string _model { get; set; }
        public Engine _engineType { get; set; }
        public Wheel[] _wheels { get; set; }

        public Car(string brand, string model, Engine engineType, Wheel[] wheels)
        {
            this._brand = brand;
            this._model = model;
            this._engineType = engineType;
            this._wheels = wheels;
        }

        public Car()
        {
            
        }

        public override string ToString()
        {
            return $"Auto marki {_brand}, model {_model}, z silnikiem {_engineType.Cylinders}-cylindrowym zasilanym paliwem {_engineType.FuelType}, na {_wheels[0].Inches}-calowych kołach";
        }
    }
}