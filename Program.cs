using System.Diagnostics;

namespace Grupparbete_EscapeRoom;

class Program
{
    
    static void Main()
    {   // Här ska vi göra en meny.
        List <FreeText> questions = new List<FreeText>();
        questions.Add(new FreeText("Vad heter sköldpaddan i Bamse?", "Skalman"));
        
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
                        Console.WriteLine(questions[0].QuestionText);
                    }                    
                    break;
                case "2":
                    isRunning = false;
                    Console.WriteLine("Tack och hej leverpastej!");
                    break; 
            }
        }
    }
}