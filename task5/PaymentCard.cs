namespace task5;

// Section 1
public class PaymentCard
{
    private double _balance;

    public PaymentCard(double balance)
    {
        _balance = balance;
    }

    public double Balance
    {
        get { return _balance; }
    }

    public void AddMoney(double amount)
    {
        if (amount > 0)
            _balance += amount;
    }

    public bool TakeMoney(double amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            return true;
        }

        return false;
    }
}

