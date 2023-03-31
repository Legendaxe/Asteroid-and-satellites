using Satellites;


bool PlayGame(Asteroid asteroid)
{

    double xRes;
    double yRes;
    double zRes;

    Satellite satellite1 = new Satellite(0, 0, 0);

    double distance1 = asteroid.GetDistanceTo(satellite1);

    Satellite satellite2 = new Satellite(distance1, 0, 0);

    double distance2 = asteroid.GetDistanceTo(satellite2);

    Satellite satellite3 = new Satellite(0, distance1, 0);

    double distance3 = asteroid.GetDistanceTo(satellite3);

    if (distance1 == 0 || distance2 == 0)
    {
        xRes = distance1; yRes = distance2; zRes = 0;
    }
    else
    {
        xRes = (2 * distance1 * distance1 - distance2 * distance2) / (2 * distance1);

        yRes = (2 * distance1 * distance1 - distance3 * distance3) / (2 * distance1);

        zRes = Math.Sqrt(Math.Abs(distance1 * distance1 - xRes * xRes - yRes * yRes));
    }

    if (asteroid.GuessPosition(Math.Round(xRes), Math.Round(yRes), Math.Round(zRes)))
        return true;
    else
        return false;
}

Asteroid[] asteroids = Enumerable.Repeat(0, 10000000).Select(a => new Asteroid()).ToArray();

foreach(Asteroid asteroid in asteroids)
{
    if (!PlayGame(asteroid))
    {
        Console.WriteLine("you lose");
    }
}
