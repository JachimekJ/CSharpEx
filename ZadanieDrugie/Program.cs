

class Program 
{
    static void Main()
    {
        int a;
        while (a >= -100 &&  a <= 100)
        {
            Console.WriteLine("Podaj liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podana liczba to: " + a);
        }
        

    }
}