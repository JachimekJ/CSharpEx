using System;
//Program, obliczający sumę trzech podanych liczb całkowitych//
class Program

 {
    static void Main() 
    {

        Console.WriteLine("Podaj pierwszą liczbę;");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę;");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj trzecią liczbę;");
        int c = int.Parse(Console.ReadLine());

        int Suma = a + b + c;

        
        Console.WriteLine("Suma podanych liczb to: " + Suma);
        
        
    }
 }