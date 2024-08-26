class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int currentTime) => ExpectedMinutesInOven() - currentTime;
    public int PreparationTimeInMinutes(int layers) => layers * 2 ;
    public int ElapsedTimeInMinutes(int layersAdded, int ovenTimer) => PreparationTimeInMinutes(layersAdded) + ovenTimer ;
}
