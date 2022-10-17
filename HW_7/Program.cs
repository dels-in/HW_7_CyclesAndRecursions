using System.Diagnostics;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out int z);

//через цикл
var stopwatchCycle = new Stopwatch();
stopwatchCycle.Start();
var list1 = new List<int>();
int y1 = 0, y2 = 1, y = 1;      
FibonacciCycle(z);          
void FibonacciCycle(int x)
{
    list1.Add(0);
    
    for (var i = 1; i < x; i++)
    {
        list1.Add(y);
        y = y1 + y2;
        y1 = y2;
        y2 = y;
    }

    Console.WriteLine(string.Join(", ", list1));
}
stopwatchCycle.Stop();
Console.WriteLine($"Время выполнения через цикл: {stopwatchCycle.Elapsed}");

//через рекурсию
var stopwatchRecursion = new Stopwatch();
stopwatchRecursion.Start();
var list2 = new List<int>();

for (var i = 0; i < z; i++)
{
    list2.Add(FibonacciRecursion(i));
}

Console.WriteLine(string.Join(", ", list2));

static int FibonacciRecursion(int x)
{
    return (x > 1) ? FibonacciRecursion(x - 1) + FibonacciRecursion(x - 2) : x;
}
stopwatchRecursion.Stop();
Console.WriteLine($"Время выполнения через рекурсию: {stopwatchRecursion.Elapsed}");
