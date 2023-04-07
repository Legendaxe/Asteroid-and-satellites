using System;

namespace Satellites
{
    internal class Asteroid
    {

        private double _x;
        private double _y;
        private double _z;

        public Asteroid(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
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
