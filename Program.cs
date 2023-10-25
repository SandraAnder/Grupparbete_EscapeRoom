using System.Diagnostics;

namespace Grupparbete_EscapeRoom;

class Program
{
    static void Main(string[] args)
    {   // Här ska vi göra en meny.
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Exit");
            string choice = Console.ReadLine()+"";
            switch (choice)
            {
                case "1":

                    break;
                case "2":
                    isRunning = false;
                    Console.WriteLine("Tack och hej leverpastej!");
                    break; 
            }
        }
    }
}