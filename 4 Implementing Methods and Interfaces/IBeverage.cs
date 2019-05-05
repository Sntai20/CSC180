// Implementing an Interface

public Interface IBeverage
	{
		int totalPoints;
    }
public class Coffee : IBeverage
{
    private int servingTempWithoutMilk { get; set; }
    private int servingTempWithtMilk { get; set; }
    public int GetServingTemperature(bool includesMilk)
    {
        if(includesMilk)
        {
            return servingTempWithtMilk;
        }
        else
        {
            return servingTempWithoutMilk;
        }
    }
    public bool IsFairTrade{ get; set; }
    // Other non-Interface members go here.
}