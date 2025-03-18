//GRA W ZGADYWANIE LICZBY PRZEZ KOMPUTER
//KOMPUTER LOSUJE LICZBĘ Z ZAKRESU 1 - 10
//USER STARA SIĘ ODGADNĄĆ LICZBĘ
//JEŚLI PODANA LICZBA JEST MNIEJSZA LUB WIĘKSZA NIŻ WYLOSOWANA - WYŚWIETL KOMUNIKAT
//KIEDY USER ODGADNIE LICZBĘ - WYŚWIETL KOMUNIKAT O WYGRANEJ

class Program
{

    static void Main(String[] args)
    {
        Random rnd = new Random();
        int wylosowanaLiczba = rnd.Next(1, 11);
        int mojaLiczba;
        do
        {
           Console.Write("Podaj liczbę od 1 do 10: ");
            mojaLiczba = int.Parse(Console.ReadLine());
            if(mojaLiczba > wylosowanaLiczba)
            {
                Console.WriteLine("Podana liczba jest za duża");
                
            }
            else if(mojaLiczba < wylosowanaLiczba)
            {
                Console.WriteLine("Podana liczba jest za mała");
            }
            else
            {
                Console.WriteLine("Brawo! Odgadłeś liczbę!");
                break;
            }
        } while (wylosowanaLiczba != mojaLiczba);
    }






}