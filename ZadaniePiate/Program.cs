//Napisz program, który oblicza sumę pojawiających się na wejściu liczb.
/* Wejście
    Na wejście programu podana zostanie pewna nieokreślona, ale niewielka ilość małych liczb całkowitych (z zakresu -100..100).
    Poszczególne liczby zostaną rozdzielone znakiem nowej linii. */
/* Wyjście
    Na wyjściu ma się pojawić ciąg liczbowy, którego i-ta pozycja jest równa sumie i pierwszych wczytanych z wejścia liczb.
    Poszczególne liczby należy rozdzielić znakami nowej linii */

class Program 
{
     static void Main(string[] args)
    {
        int suma = 0;  // Przechowuje aktualną sumę
        string? linia; // String do przechowywania wczytanej wartości

    

        while ((linia = Console.ReadLine()) != null) // Czytaj do końca
        {
            int liczba = int.Parse(linia); // Konwersja wczytanej wartości na liczbę
            if (liczba >= -100 && liczba <= 100) // Sprawdzenie czy liczba jest z zakresu
            {
            suma += liczba; // Dodanie do sumy
            Console.WriteLine(suma); // Wypisanie aktualnej sumy
            }

            else
            {
                Console.WriteLine("Liczba nie jest z zakresu -100..100");
                break;
            } 
        }
    }
}