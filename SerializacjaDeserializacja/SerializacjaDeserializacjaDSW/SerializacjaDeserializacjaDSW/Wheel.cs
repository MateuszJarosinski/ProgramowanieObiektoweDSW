using System.ComponentModel;

namespace SerializacjaDeserializacjaDSW
{
    public class Wheel
    {
        //definiuje czy dane koło obraca się czy jest stałe
        public bool isSteering;
        //definiuje czy koło napędza samochód
        public bool isPowered;
        //definiuje czy koło będzie posiadało klocki hamulcowe
        public bool isBraking;

        private int _inches = 1;

        public int Inches
        {
            get
            {
                return _inches;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidEnumArgumentException("Caale w kołach muszą być liczbą dodatnią");
                }
                else
                {
                    _inches = value;
                }
            }
        }

        public Wheel(bool isSteering, bool isPowered, bool isBraking, int inches)
        {
            this.isSteering = isSteering;
            this.isPowered = isPowered;
            this.isBraking = isBraking;
            Inches = inches;
        }
    }
}