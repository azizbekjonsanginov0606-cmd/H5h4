namespace task5;

// Section 2
public class PaymentTerminal
{
    private double _cashInRegister;
    private const double LunchPrice = 2.50;
    private const double CoffeePrice = 1.50;
    private int _lunchesSold;
    private int _coffeesSold;

    public PaymentTerminal()
    {
        _cashInRegister = 1000.0;
    }

    public double PayLunch(double cashGiven)
    {
        if (cashGiven >= LunchPrice)
        {
            _cashInRegister += LunchPrice;
            _lunchesSold++;
            return cashGiven - LunchPrice;
        }

        return cashGiven;
    }

    public double PayCoffee(double cashGiven)
    {
        if (cashGiven >= CoffeePrice)
        {
            _cashInRegister += CoffeePrice;
            _coffeesSold++;
            return cashGiven - CoffeePrice;
        }

        return cashGiven;
    }
    // Section 3
    public bool PayLunchCard(PaymentCard card)
    {
        if (card.TakeMoney(LunchPrice))
        {
            _lunchesSold++;
            return true;
        }

        return false;
    }

    public bool PayCoffeeCard(PaymentCard card)
    {
        if (card.TakeMoney(CoffeePrice))
        {
            _coffeesSold++;
            return true;
        }

        return false;
    }
    // Section 4
    public void AddMoneyToCard(PaymentCard card, double amount)
    {
        if (amount > 0)
        {
            card.AddMoney(amount);
            _cashInRegister += amount;
        }
    }
}
