using System;

public static class KataZeroFuel
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
    {

        return fuelLeft * mpg >= distanceToPump;
        
    }
}