using System.Diagnostics.CodeAnalysis;
int MinMax(int per1,int per2)
{
	int max = 0;
	if (per1 < per2)
		max = per2;
	else if (per1>=per2)
        max = per1;
	return max;
}

Console.WriteLine("Введи первое число");
Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введи первое число");
Console.Write("b=");
int b = int.Parse(Console.ReadLine());


Console.WriteLine(); //отступ
Console.WriteLine("a="+a+" "+"b="+b+" "+"->"+"max="+MinMax(a, b));