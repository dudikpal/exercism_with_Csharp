namespace SpaceAge {
    public class SpaceAge
    {
        private double _seconds;
        private const double _SECONDS_OF_YEAR = 31557600;
        public SpaceAge(int seconds)
        {
            _seconds = seconds;
        }
        private double convertToAnotherYear(double period)
        {
            return _seconds / _SECONDS_OF_YEAR / period;
        }
        public double OnEarth() => convertToAnotherYear(1);
        public double OnMercury() => convertToAnotherYear(0.2408467);
        public double OnVenus() => convertToAnotherYear(0.61519726);
        public double OnMars() => convertToAnotherYear(1.8808158);
        public double OnJupiter() => convertToAnotherYear(11.862615);
        public double OnSaturn() => convertToAnotherYear(29.447498);
        public double OnUranus() => convertToAnotherYear(84.016846);
        public double OnNeptune() => convertToAnotherYear(164.79132);
    
    }
}