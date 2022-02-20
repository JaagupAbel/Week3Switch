using System;

namespace GradingSwitch
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
            //kasutame SWITCH

            Console.WriteLine("Sisest oma tulemus:");
            string userTulemus = Console.ReadLine().ToLower();

            switch (userTulemus)
            {
                case "a":
                    Console.WriteLine("Suurepärane!");
                    break;
                case "b":
                    Console.WriteLine("Väga hea!");
                    break;
                case "c":
                    Console.WriteLine("Hea!");
                    break;
                case "d":
                    Console.WriteLine("Rahuldav!");
                    break;
                case "e":
                    Console.WriteLine("Kasin!");
                    break;
                case "f":
                    Console.WriteLine("Puudulik!");
                    break;

                default:
                    Console.WriteLine($"{userTulemus} on vale väärts!");
                    break;
            }
            Console.WriteLine("Aitäh vastamast!");
        }
    }
}

