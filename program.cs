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
Console.WriteLine();
List<char> spec_karakterek = new() { '.', '-', '_' };
Console.Write("Kérem a jelszót: ");
string jelszo = Console.ReadLine();
int erosseg(string password)
{
    int strength = 1;

    if (password.Length >= 5)
    {
        strength += 1;  
    }
    
    if (password.Length >= 8)
    {
        strength += 2; 
    }

  
    foreach (char karakter in password)
    {
        if (spec_karakterek.Contains(karakter))
        {
            strength += 2;
           
        }
    }
    if (password.Contains("jelszo"))
    {
        strength = 0;
    }
    if (password.Contains("123"))
    {
        strength = 0;
    }
    return strength;
}

Console.WriteLine(erosseg(jelszo));
Console.WriteLine();
Console.Write("Adjon meg egy szöveget: ");

string szoveg=Console.ReadLine();
string maganhangzotorol(string s)
{
    string eredmeny = "";
    string maganhangzok = "aeiouáéíóöőúüű";

    foreach (char c in s)
    {
        if (maganhangzok.Contains(c))
        {
            continue;
        }
        else
        {
            eredmeny += c;
        }
    }
    return eredmeny;
}

Console.WriteLine(maganhangzotorol(szoveg));

Console.WriteLine();
Console.Write("Adja meg a titkosítani kivánt szöveget: ");
string szoveg2 = Console.ReadLine();
Console.Write("Adja meg hány karakterrel szertné eltolni a szöveget: ");
int db=int.Parse(Console.ReadLine());
Console.Write("Add meg a karaktert amit használni szeretnél a titkosításhoz: ");
char karakter1 = char.Parse(Console.ReadLine());

string titkosit(string s, int db, char karakter)
{
    string eredmeny = "";
    foreach (char c in s)
    {
        eredmeny += c;
        for (int i = 0; i < db; i++)
        {
            eredmeny += karakter;
        }
    }
    return eredmeny;
}

Console.WriteLine(titkosit(szoveg2, db, karakter1));