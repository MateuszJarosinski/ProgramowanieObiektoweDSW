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

        private int _inches;

        public int Inches
        {
            get
            {
                return _inches;
            }
            set
            {
                
            }
        }
    }
}