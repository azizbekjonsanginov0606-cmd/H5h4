namespace task3;

public class Gauge
{
    public int Value { set; get; } = 0;
    public void Increase()
    {
        if (Value < 5)
            Value++;
    }
    public void Decrease()
    {
        if (Value > 0)
            Value--;
    }
    public bool Full()
    {
        if (Value == 5)
            return true;
        else
            return false;
    }
}
