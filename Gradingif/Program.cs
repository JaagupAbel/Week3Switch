using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
             //Programm küsib, mis hinde kasutaja sai.
             //Kui kasuta sai "A", konsool kuvab "Suurepärane!";
             //Kui tulemus on "B", konsool kuvab "Väga hea!";
             //Kui tulemus on "C", konsool kuvab "Hea!";
             //Kui tulemud on "D", konsool kuvab "Rahuldav!";
             //Kui tulemus on "E", konsool kuvab "Kasin!";
             //Kui tulemus on "F", konsool kuvab "Puudulik!";
             //Kui kasutaja siestab midagi muus, siis konsool kuvab "Vale väärtus!";
             //kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult =J= 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine($"{userResult} on vale väärtus!");
            }
            Console.WriteLine("Head päeva!");
        }
    }
}
