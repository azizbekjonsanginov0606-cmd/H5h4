// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task3;

Gauge gauge = new();
gauge.Value = 5;

gauge.Increase();
Console.WriteLine("Increase()");
Console.WriteLine("Value = " + gauge.Value);

gauge.Decrease();
Console.WriteLine("Decrease()\n" + "Value = " + gauge.Value);
Console.WriteLine("Full()\n" + "Value = " + gauge.Full());
