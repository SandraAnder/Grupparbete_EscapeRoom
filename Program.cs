using System.Diagnostics;
using System.Collections.Generic;

namespace Grupparbete_EscapeRoom;

class Program
{
    
    static void Main()
    {   // Här ska vi göra en meny.
        List <FreeText> questions = new List<FreeText>();
        questions.Add(new FreeText("Vad heter sköldpaddan i Bamse? ", "skalman"));
        //questions.Add(new FreeText("Vad heter kaninen i Bamse?", "Lille Skutt"));

        int playerLives = 10;
        
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Exit");
            string choice = Console.ReadLine()+"";
            switch (choice)
            {
                case "1":
                    for (int i = 0; i < questions.Count; i++)
                    {
                        Console.Write(questions[i].QuestionText);
                    
                        string? userAns = Console.ReadLine();
                        if (questions[i].CheckAnswer(userAns.ToLower()) == true) //Fråga Krister om det inte finns ett bättre sätt. Varför CheckAnswer?
                        {
                            Console.WriteLine("Rätt");
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                            playerLives--;
                            Console.WriteLine($"Du har nu {playerLives} liv kvar...");
                        }
                    }
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