// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task5;
PaymentTerminal terminal = new PaymentTerminal();

PaymentCard card = new PaymentCard(10.0);

Console.WriteLine("Balance : " + card.Balance);

bool coffeePaid = terminal.PayCoffeeCard(card);
Console.WriteLine("Pay Coffee Card : " + coffeePaid);
Console.WriteLine("Balance after coffee : " + card.Balance);

bool lunchPaid = terminal.PayLunchCard(card);
Console.WriteLine("Pay Lunch Card : " + lunchPaid);
Console.WriteLine("Balance after Lunch : " + card.Balance);

double changeLunch = terminal.PayLunch(5.0);
Console.WriteLine("changeLunch : " + changeLunch);

double changeCoffee = terminal.PayCoffee(10.0);
Console.WriteLine("changeCoffee : " + changeCoffee);

Console.WriteLine("Balance : " + card.Balance);

terminal.AddMoneyToCard(card, 20.0);
Console.WriteLine("Add Money To Card : " + card.Balance);