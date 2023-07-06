Console.WriteLine("Вывести все чётные число от 0 до N");
Console.Write("N=");
int N =int.Parse(Console.ReadLine());
int[] mass = new int[N];
for (int i = 0; i < N; i++)
    {
     mass[i] = i;
    
    if (mass[i]%2== 0) 
        {
        Console.Write(mass[i]+" ");
        }
    
    }
    

//Console.WriteLine("The end!");
