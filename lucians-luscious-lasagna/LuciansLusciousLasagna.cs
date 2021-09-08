class Lasagna
{

    private int EXPECTED_MINUTES_IN_OVEN = 40;

    private int MINUTES_TO_PREPARING_LAYER = 2;

    
    public int ExpectedMinutesInOven()
    {
        return EXPECTED_MINUTES_IN_OVEN;
    }

    
    public int RemainingMinutesInOven(int actualInTheOven)
    {
        return EXPECTED_MINUTES_IN_OVEN - actualInTheOven;
    }

    
    public int PreparationTimeInMinutes(int numberOfLayer)
    {
        return numberOfLayer * MINUTES_TO_PREPARING_LAYER;
    }

    
    public int ElapsedTimeInMinutes(int layers, int actualInTheOven)
    {
        return PreparationTimeInMinutes(layers) + actualInTheOven;
    }
}
