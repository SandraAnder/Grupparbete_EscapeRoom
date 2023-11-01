public class Challange1
{
    public int playerLives = 5;
    List <Question> questions = new List<Question>();

    public void Room1()
    {
        Console.WriteLine("Du kliver in i rummet, där ser du en obäddad säng tvärs över rummet. \nTill höger ser du en kamin med en blodig handduk hängande på tork. \nTill vänster ser du ett skrivbord med en uppslagen karta. \nDörren bakom dig slår igen och låser sig. Nu behöver du hitta en annan väg ut...");
        
        questions.Add(new FreeText("Det är som alla vet, polisen som sköter brottsbekämpningen. \nMen vad kallas det när allmänheten griper en misstänkt? ", "Envarsgripande"));

        bool isLooping = true;
        while (isLooping)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Gå till den obäddade sängen.");
            Console.WriteLine("2. Gå fram till kaminen och den blodiga handduken.");
            Console.WriteLine("3. Gå till skrivbordet och kartan.");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Du kikar under täcket, men det är tomt.");
                    break;
                case "2":
                    Console.WriteLine("Du lyfter upp handduken och ett halvt foto ramlar ut. På baksidan står det: ");
                    for (int i = 0; i < questions.Count; i++)
                    {
                        Console.Write(questions[0].QuestionText);
                        string? userAns = Console.ReadLine();
                        if (questions[i].CheckAnswer(userAns+"".ToLower()) == true)
                        {
                            Console.WriteLine("Rätt! Du hör en dörr öppnas bakom en gardin och du går in.");
                            Console.WriteLine();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                            playerLives--;
                            Console.WriteLine($"Du har nu {playerLives} liv kvar...");
                            Console.WriteLine();
                            break;
                        }
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Du går fram till skrivbordet och tittar på kartan. \nDär hittar du ett tomt anteckningsblock och en penna. \nMen inget av direkt intresse för dig.");
                    break;
                default:
                    Console.WriteLine("Men kom igen! Svara 1, 2 eller 3!");
                    break;
            }
        }
    }
    public void Room2()
    {
        Console.WriteLine("HEJ HOPP RUM 2");
        
        questions.Add(new FreeText("Du ser en signatur av Johanna Möller. Även kallad? ", "arbogakvinnan"));
        questions.Add(new FreeText("Vad heter kaninen i Bamse? ", "lille skutt"));
        questions.Add(new MultipleChoice("Vad kommer efter hej? ", "hopp", "dopp", "hopp"));
        questions.Add(new OneXTwo("Vad vill du äta till middag? ", "falafel", "tacos", "spagetti", "falafel"));
        questions.Add(new FreeText("Jag har städer, men inget hus. Jag har skog, men inga träd. Jag har floder, men inget vatten. Vad är jag? ", "En karta. Kartor har städer, skogar och floder ritade på dem, men de är inte verkliga hus, träd eller vatten"));

        bool isLooping = true;
        while (isLooping)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Gå till den obäddade sängen.");
            Console.WriteLine("2. Gå fram till kaminen och den blodiga handduken.");
            Console.WriteLine("3. Gå till skrivbordet och kartan.");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Du kikar under täcket, men det är tomt.");
                    break;
                case "2":
                    Console.WriteLine("Du lyfter upp handduken och ett halvt foto ramlar ut. På baksidan står det: ");
                    for (int i = 0; i < questions.Count; i++)
                    {
                        Console.Write(questions[0].QuestionText);
                        string? userAns = Console.ReadLine();
                        if (questions[i].CheckAnswer(userAns+"".ToLower()) == true)
                        {
                            Console.WriteLine("Rätt! Du hör en dörr öppnas bakom en gardin och du går in.");
                            Console.WriteLine();
                            
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                            playerLives--;
                            Console.WriteLine($"Du har nu {playerLives} liv kvar...");
                            Console.WriteLine();
                            break;
                        }
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Du går fram till skrivbordet och tittar på kartan. \nDär ");
                    break;
                default:
                    Console.WriteLine("Men kom igen! Svara 1, 2 eller 3!");
                    break;
            }
        }
    }

}

public class Challange2
{
    public void Room1()
    {

    }
}