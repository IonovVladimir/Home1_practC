Console.WriteLine("Чётноели число?");
Console.Write("Введите число=");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
if (number % 2 == 0)
Console.WriteLine(number+" "+"число чётное");
else
Console.WriteLine(number+" "+"число нечётное");
