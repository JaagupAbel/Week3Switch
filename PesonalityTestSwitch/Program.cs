using System;

namespace PesonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch(userColor)
            {
                case "punane": //if(userColor = "Punane")
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töötkas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
