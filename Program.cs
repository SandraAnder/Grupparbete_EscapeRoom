using System.Diagnostics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace Grupparbete_EscapeRoom;

class Program
{
     
   static void Main()
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
                  Game play = new Game();
                  play.Play();
                  break;
               case "2":
                  isRunning = false;
                  Console.WriteLine("Tack och hej leverpastej!");
                  break; 
               default:
               {
                  Console.WriteLine("Du har två val... Kom igen, 1 eller 2... Hur svårt kan det vara...");
               }
               break;
         }
      }
    }
}