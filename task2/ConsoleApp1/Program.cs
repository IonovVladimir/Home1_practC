double MinMax(double p1, double p2, double p3)
{ 
double max=0;
    if (p1 >= p2 && p1 >= p3 )
        max = p1;
    else if (p2 >= p1 && p2 >= p3)
        max=p2;
    else if (p3 >= p1 && p3 >= p2)
        max = p3;
    return max;
}

Console.WriteLine("Введи а:");
Console.Write("а=");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введи b:");
Console.Write("b=");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введи c:");
Console.Write("c=");
double c = double.Parse(Console.ReadLine());

Console.WriteLine();// отступ
Console.WriteLine("a="+a+" "+"b="+b+" "+"c="+c+" "+"->"+"max="+MinMax(a,b,c));
