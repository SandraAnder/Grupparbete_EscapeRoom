public class ChallangeCrime
{
    public int playerLives = 5;
    List <Question> questions = new List<Question>();
    

    public void Room1()
    {
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("        ‡        Du kliver in i rummet, där ser du en obäddad säng tvärs över rummet.      ‡ \n        ‡         Till höger ser du en kamin med en blodig handduk hängande på tork.       ‡ \n        ‡            Till vänster ser du ett skrivbord med en uppslagen karta.             ‡ \n        ‡ Dörren bakom dig slår igen och låser sig. Nu behöver du hitta en annan väg ut... ‡ ");
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ReadLine();
        questions.Add(new FreeText("Vilket var den vanligaste typen av mordvapen i Sverige 2022? \nA. Kniv \nB. Pilbåge \nC. Skjutvapen", "c"));
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
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Du lyfter upp handduken och ett halvt foto ramlar ut. På baksidan står det: ");
                    for (int i = 0; i < questions.Count;)
                    {
                        Console.WriteLine(questions[0].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAns = Console.ReadLine();
                        if (questions[i].CheckAnswer(userAns.ToLower()) == true)
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
                            Console.ReadLine();
                            break;
                        }
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
        Console.WriteLine("Du tar ett steg in i något som ser ut som ett förråd och en unken doft slår mot ansiktet. \nHyllor fyllda med lådor,burkar och diverse bråte sträcker sig längst väggarna. \nDet står ett kassaskåp i hörnet, du går fram till kassakåpet och upptäcker att det är låst. \nFör att öppna skåpet behövs en fyrsiffrig kod.");
        
        //questions.Add(new FreeText("Det är polisen som sköter brottsbekämpningen. \nMen vad kallas det när allmänheten griper en misstänkt? ", "envarsgripande"));
        questions.Add(new FreeText("Vad heter den ökände seriemördaren också kallad “Leather appron” som härjade runt i Whitechappel, London på 1800-talet?, \nA. Jack The Ripper \nB. Spagetti \nC. Falafel", "a"));
        questions.Add(new FreeText("Hur många år i snitt sitter en livstidsdömd person i fängelse i Sverige? \nA. 20 \nB. 16 \nC. 10", "b"));
        
        bool isLooping = true;
        while (isLooping)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Vart vill du leta?");
            Console.WriteLine("1. Hyllan längst upp till höger.");
            Console.WriteLine("2. Trätunnan mitt i rummet.");
            Console.WriteLine("3. Gå till kassaskåpet.");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Du rotar runt på hyllan och hittar en liten papperslapp där det står '..32' . Kan det här höra till koden?");
                    Console.WriteLine("Tryck enter för att fortsätta");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Du lyfter på locket. ");
                        Console.WriteLine(questions[2].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAns = Console.ReadLine();
                        if (questions[2].CheckAnswer(userAns.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt! Kan svaret vara en del av den fyrsiffriga koden?");
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
                    break;
                case "3":
                    Console.WriteLine("Du går till kassaskåpet. Skriv in en fyrsiffrig kod.");
                    int safeCode = int.Parse(Console.ReadLine()+"");
                    if (safeCode != 1632)
                    {
                        Console.WriteLine("Fel");
                        playerLives--;
                        Console.WriteLine($"Du har nu {playerLives} liv kvar...");
                        Console.WriteLine();
                        break;
                    }
                    else if (safeCode == 1632)
                        Console.WriteLine("Du lyckades öppna kassaskåpet. Här kommer en fråga: ");
                        
                        Console.WriteLine(questions[1].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAn = Console.ReadLine();
                        if (questions[1].CheckAnswer(userAn.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt! Bakpanelen öppnar sig och du kliver igenom till nästa rum.");
                            Console.WriteLine();
                            return;
                        }
                        /*else
                        {
                            Console.WriteLine("Fel");
                            playerLives--;
                            Console.WriteLine($"Du har nu {playerLives} liv kvar...");
                            Console.WriteLine();
                            break;
                        }*/
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Men kom igen! Svara 1, 2 eller 3!");
                    break;
            }
        }
    }
    public void Room3()
    {
        Console.WriteLine("RUUUM 3");
        
        questions.Add(new MultipleChoice("Vilka brott kan ge livstids fängelse i Sverige? (Ett eller fler alternativ är rätt. Separera ditt svar med mellanslag) \nA. Dråp \nB. Miljöbrott \nC. Mord \nD. Förskingring \nE. Människorov", "c e", "e c"));
        //questions.Add(new FreeText("Hur många år i snitt sitter en livstidsdömd person i fängelse i Sverige? \nA. 20 \nB. 16 \nC. 10", "b"));
        
        bool isLooping = true;
        while (isLooping)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Vart vill du leta?");
            Console.WriteLine("1. x längst upp till höger.");
            Console.WriteLine("2. y mitt i rummet.");
            Console.WriteLine("3. Gå till z.");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Du rotar runt på hyllan och hittar en liten papperslapp där det står '..32' . Kan det här höra till koden?");
                    Console.WriteLine("Tryck enter för att fortsätta");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Du lyfter på locket. ");
                        Console.WriteLine(questions[3].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAns = Console.ReadLine();
                        if (questions[3].CheckAnswer(userAns.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt! Kan svaret vara en del av den fyrsiffriga koden?");
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
                    break;
                case "3":
                    Console.WriteLine("Du går till kassaskåpet. Skriv in en fyrsiffrig kod.");
                    int safeCode = int.Parse(Console.ReadLine()+"");
                    if (safeCode == 1632)
                        Console.WriteLine("Du lyckades öppna kassaskåpet. Här kommer en fråga: ");
                        
                        Console.WriteLine(questions[1].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAn = Console.ReadLine();
                        if (questions[1].CheckAnswer(userAn.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt! Bakpanelen öppnar sig och du kliver igenom till nästa rum.");
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