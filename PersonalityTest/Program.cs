using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada tema lemmik värv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //Kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmik värv:");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} üksiksarvik.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
