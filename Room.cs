class Room
{
    List <Question> questions = new List<Question>();

    public void Room1()
    {
        questions.Add(new FreeText("Vad heter sköldpaddan i Bamse? ", "skalman"));
        questions.Add(new FreeText("Vad heter kaninen i Bamse? ", "lille skutt"));
        questions.Add(new MultipleChoice("Vad kommer efter hej? ", "hopp", "dopp", "hopp"));
        questions.Add(new OneXTwo("Vad vill du äta till middag? ", "falafel", "tacos", "spagetti", "falafel"));
        questions.Add(new Riddle("Jag har städer, men inget hus. Jag har skog, men inga träd. Jag har floder, men inget vatten. Vad är jag? ", "En karta. Kartor har städer, skogar och floder ritade på dem, men de är inte verkliga hus, träd eller vatten"));

        for (int i = 0; i < questions.Count; i++)
        {
            Console.Write(questions[i].QuestionText);
            
        
            string? userAns = Console.ReadLine();
            if (questions[i].CheckAnswer(userAns.ToLower()) == true)
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