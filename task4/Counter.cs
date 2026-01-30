namespace task4;

public class Counter
{
    public int Value { get; set; }

    public Counter(int startValue=0)
    {
        Value=startValue;
    }
   public void  Increase()
    {
        Value++;
    }
    public void Decrease()
    {
        Value--;
    }
   public void  Increase(int increaseBy)
    {
        if (increaseBy>0)
        {
            Value+=increaseBy;
        }
    }
    public void  Decrease(int reduceBy)
    {
        if (reduceBy>0)
        {
            Value-=reduceBy;
        }
    }
}
