class Room
{
    List <FreeText> questions = new List<FreeText>();
    public void Room1()
    {
        questions.Add(new FreeText("Vad heter sköldpaddan i Bamse? ", "skalman"));
        questions.Add(new FreeText("Vad heter kaninen i Bamse?", "lille skutt"));
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
        questions.Add(new FreeText("Vad heter sköldpaddan i Bamse? ", "skalman"));
    }

}