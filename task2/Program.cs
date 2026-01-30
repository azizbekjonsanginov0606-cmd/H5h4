// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int cnt=0;
while (true)
{
    Console.Write("> ");
    string? a = Console.ReadLine().ToLower();
    // if (a=="end")
    // {
    //     break;
    // }
    // cnt++;
    if (a != "end")
        cnt++;
    else
    break;
}
Console.WriteLine(cnt);