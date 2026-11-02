Console.Write("Kérem az első számot: ");
int egyik = int.Parse(Console.ReadLine());

Console.Write("Kérem a második számot: ");
int masik = int.Parse(Console.ReadLine());

int AbsMax(int a, int b)
{
    if (Math.Abs(a) > Math.Abs(b))
    {
        return Math.Abs(a);
    }
    else
    {
        return Math.Abs(b);
    }   
}


Console.WriteLine(AbsMax(egyik, masik));

List<int> list = new() {0, 1};

Console.WriteLine();
Console.Write("Adj meg egy egész számot: ");
int fibo=int.Parse(Console.ReadLine()); 

int Fibonacci(int n)
{
    for (int i = 2; i <= n; i++)
        list.Add(list[i - 1] + list[i - 2]);

    return list[n];

}

Console.WriteLine(Fibonacci(fibo));