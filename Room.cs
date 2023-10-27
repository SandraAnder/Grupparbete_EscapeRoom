class Room
{
    public void Room1()
    {
        List <FreeText> questions = new List<FreeText>();
        questions.Add(new FreeText("Vad heter sköldpaddan i Bamse? ", "skalman"));
        
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
                /*playerLives--;
                Console.WriteLine($"Du har nu {playerLives} liv kvar...");*/
            }
        }
    }

    public void Room2()
    {

    }

}