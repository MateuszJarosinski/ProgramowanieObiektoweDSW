using System.Security.Principal;

namespace SerializacjaDeserializacjaDSW
{
    public class Car
    {
        private string _brand;
        private string _model;
        private Engine _engineType;
        private Wheel[] _wheels;

        public Car(string brand, string model, Engine engineType, Wheel[] wheels)
        {
            this._brand = brand;
            this._model = model;
            this._engineType = engineType;
            this._wheels = wheels;
        }

        public override string ToString()
        {
            return $"Auto marki {_brand}, model {_model}, z silnikiem {_engineType.Cylinders}-cylindrowym zasilanym paliwem {_engineType.FuelType}, na {_wheels[0].Inches}-calowych kołach";
        }
    }
}