public class Challange1
{
    public int playerLives = 5;
    List <Question> questions = new List<Question>();

    public void Room1()
    {
        Console.WriteLine("Du kliver in i rummet, där ser du en obäddad säng tvärs över rummet. Till höger ser du en kamin med en blodig handduk hängande på tork. Till vänster ser du ett skrivbord med uppslagen en karta");
        
        questions.Add(new FreeText("Du ser en signatur av Johanna Möller. Även kallad? ", "arbogakvinnan"));
        questions.Add(new FreeText("Vad heter kaninen i Bamse? ", "lille skutt"));
        questions.Add(new MultipleChoice("Vad kommer efter hej? ", "hopp", "dopp", "hopp"));
        questions.Add(new OneXTwo("Vad vill du äta till middag? ", "falafel", "tacos", "spagetti", "falafel"));
        questions.Add(new FreeText("Jag har städer, men inget hus. Jag har skog, men inga träd. Jag har floder, men inget vatten. Vad är jag? ", "En karta. Kartor har städer, skogar och floder ritade på dem, men de är inte verkliga hus, träd eller vatten"));

        while (true)
        {
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Gå till den obäddade sängen.");
            Console.WriteLine("2. Gå fram till kaminen och den blodiga handduken.");
            Console.WriteLine("3. Gå till skrivbordet och kartan.");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Du kikar täcket, men det är tomt.");
                    break;
                case "2":
                    Console.WriteLine("Du lyfter upp handduken och ett halvt foto ramlar ut. På baksidan står det: ");
                    for (int i = 0; i < questions.Count; i++)
                    {
                        Console.Write(questions[0].QuestionText);
                        string? userAns = Console.ReadLine();
                        if (questions[i].CheckAnswer(userAns+"".ToLower()) == true)
                        {
                            Console.WriteLine("Rätt");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                            playerLives--;
                            Console.WriteLine($"Du har nu {playerLives} liv kvar...");
                            Console.WriteLine();
                        }
                        Console.WriteLine("Tryck 'Enter' för nästa fråga");
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Men kom igen! Svara 1, 2 eller 3!");
                    break;
            }
        }
    }
    public void Room2()
    {
        questions.Add(new FreeText("Vad heter sköldpaddan i Bamse? ", "skalman"));
    }

}

public class Challange2
{
    public void Room1()
    {

    }
}