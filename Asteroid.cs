namespace Satellites
{
    internal class Asteroid
    {

        private double _x;
        private double _y;
        private double _z;

        public Asteroid()
        {
            Random random = new Random();
            _x = random.Next(0, 100);
            _y = random.Next(0, 100);
            _z = random.Next(0, 100);
        }

        internal double GetDistanceTo(Satellite satellite)
        {
            double x = _x - satellite.X;
            double y = _y - satellite.Y;
            double z = _z - satellite.Z;
            return Math.Sqrt(x * x + y * y + z * z);
        }

        internal bool GuessPosition(double x, double y, double z)
        {
            return (_x == x && _y == y && _z == z) ? true : false;
        }
    }
}
