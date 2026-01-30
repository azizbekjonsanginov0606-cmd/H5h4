// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task4;

Counter counter = new();
Console.WriteLine("startValue = " + counter.Value + "\n");
Console.WriteLine("=====================");

counter.Increase();
Console.Write("Increase() : ");
Console.WriteLine("Value = " + counter.Value + "\n");
Console.WriteLine("=====================");

counter.Decrease();
Console.Write("Decrease() : ");
Console.WriteLine("Value = " + counter.Value + "\n");
Console.WriteLine("=====================");

counter.Increase(5);
Console.Write("Increase(5) : ");
Console.WriteLine("Value = " + counter.Value + "\n");
Console.WriteLine("=====================");

counter.Decrease(4);
Console.Write("Decrease(4) : ");
Console.WriteLine("Value = " + counter.Value + "\n");