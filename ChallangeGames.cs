using System.Collections;
using System.Runtime.InteropServices;

public class ChallangeGames
{
    public int playerLives = 5;
    List <Question> questionsgame = new List<Question>();

    public void Room1()
    {
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("        §        Du tar ett steg in i rummet, där ser du en säng, ett skrivbord och en TV som brusar med myrornas krig.       § \n        §    Under TV:n ser du ett gammalt supernintendo med två kontroller ikopplade och framför TV:n ligger en sackosäck.   § \n        §                      Vid sängens fotände står en byrå fylld med lego, brädspel och tidningar.                       § \n        §                    Dörren bakom dig stängs och låser sig. Nu behöver du hitta en annan väg ut...                    § ");
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ReadLine();

        questionsgame.Add(new FreeText("Vad har TV-spelsfiguren Pacman för färg?\nA. Grön \nB. Vit \nC. Röd \nD. Gul", "d"));
        questionsgame.Add(new FreeText("Vad heter Supermarios bror? \nA. Ludwig \nB. Luigi \nC. Pepparoni \nD. Bowser", "b"));

        bool isLooping = true;
        while (isLooping)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Du ser en garderob med ett ordlås på som verkar behöva två ord för att öppnas. Se vad du kan hitta.");
            Console.WriteLine("1. Gå till TV:n.");
            Console.WriteLine("2. Gå fram och kika på Supernintendot.");
            Console.WriteLine("3. Gå till byrån och leta där.");
            Console.WriteLine("4. Gå fram till garderoben och titta på låset.");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Du går fram och slår om TV:n till en annan inkälla och nu ser du något i rutan.");
                    for (int i = 0; i < questionsgame.Count; /*i++*/)
                    {
                        Console.WriteLine(questionsgame[0].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAns = Console.ReadLine();
                        if (questionsgame[i].CheckAnswer(userAns.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt!");
                            Console.WriteLine();
                            break;
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
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Du böjer dig ner och tittar på spelet som sitter i. Du tar loss det och blåser på stiften för att få bort damm..");
                    for (int i = 0; i < questionsgame.Count; /*i++*/)
                    {
                        Console.WriteLine(questionsgame[1].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAns = Console.ReadLine();
                        if (questionsgame[1].CheckAnswer(userAns.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt!");
                            Console.WriteLine();
                            break;
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
                    Console.WriteLine("Du ser bara massa halvbyggt lego och serietidningar ligga om vart annat i hyllorna..");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Du går fram till låset och ser att du behöver fylla i två ord: Vad gör du?");
                    bool isRunning = true;

                    while (isRunning)
                    {
                        Console.WriteLine("1. Testa låset. ");
                        Console.WriteLine("2. Fortsätt leta");
                        string userInp = Console.ReadLine();

                        switch (userInp.ToLower())
                        {
                            case "1":
                                Console.Write("Skriv in två ord separerat med ett mellanslag: ");
                                string? wordCode = Console.ReadLine();
                                
                                if (wordCode == "gul luigi")
                                {
                                    Console.WriteLine("Rätt! Nytt rum");
                                    Console.WriteLine();
                                    return;
                                }
                                
                                else if (wordCode == "luigi gul")
                                {
                                    Console.WriteLine("Rätt! Nytt rum");
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
                            case "2":
                                Console.WriteLine("Du fortsätter leta");
                                isRunning = false;
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Men kom igen! Svara 1, 2, 3 eller 4!");
                    break;
            }
        }
    }
    public void Room2()
    {
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");                                                 //------------------------------------------------------------------                                                                           ------------------------------------------------------------------                              ------------------------------------------------------------------
        Console.WriteLine("        ‡              Du kommer in i ett mörkt rum och den enda ljuskällan kommer från en datorskärm.             ‡ \n        ‡                    Du sätter dig framför tangentbordet och ett konsolfönster dyker upp.                  ‡ \n        ‡                                   Du ska navigera dig runt och hitta ut.                                 ‡ \n        ‡  Dörren bakom dig försvann i mörkret och det är bara du och datorn kvar. Nu behöver du ta dig vidare...  ‡ ");
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ReadLine();

        questionsgame.Add(new FreeText("Vilket var världens mest sålda PC-spel (2005)? (Olika releaser summerade)?\nA. Half Life \nB. Zelda \nC. The Sims \nD. Final Fantasy \nE. Super Mario", "c"));
        questionsgame.Add(new FreeText("Vad heter hjälten i spelen Zelda?\nA. Mario \nB. Law \nC. Hero \nD. Link", "d"));

        Console.WriteLine("På skärmen ser du några alternativ");
        Console.WriteLine();
        Console.WriteLine("Vart vill du börja?");

        bool isLooping = true;
        while (isLooping)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Se vad som finns på skrivbordet");
            Console.WriteLine("2. Gå till dokumentmappen");
            Console.WriteLine("3. Gå gamesmappen");
            Console.WriteLine("4. Kan det finnas en kod för att ta sig vidare?");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Text börjar rulla på skärmen och du kan läsa: ");
                    for (int i = 0; i < questionsgame.Count;)
                    {
                        Console.WriteLine(questionsgame[2].QuestionText);
                        Console.Write("Ditt svar: ");
                        string? userAns = Console.ReadLine();
                        if (questionsgame[2].CheckAnswer(userAns.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt!");
                            Console.WriteLine();
                            break;
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
                case "2":
                    Console.WriteLine("Du öppnar mappen och ser: ");
                    for (int i = 0; i < questionsgame.Count;)
                    {
                        Console.WriteLine(questionsgame[3].QuestionText);
                        Console.Write("Ditt svar: ");
                        string? userAns = Console.ReadLine();
                        if (questionsgame[3].CheckAnswer(userAns.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt!");
                            Console.WriteLine();
                            break;
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
                    Console.WriteLine("Inne i gamesmappen ser du att det finns ett enda spel. 'BlackJack' men det går inte att öppna.");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Du går fram till låset och ser att du behöver fylla i några ord: Vad gör du?");
                    bool isRunning = true;

                    while (isRunning)
                    {
                        Console.WriteLine("1. Testa låset. ");
                        Console.WriteLine("2. Fortsätt leta");
                        string userInp = Console.ReadLine();

                        switch (userInp.ToLower())
                        {
                            case "1":
                                Console.Write("Skriv in dina ord separerat med ett mellanslag: ");
                                string? wordCode = Console.ReadLine();
                                
                                if (wordCode == "the sims link")
                                {
                                    Console.WriteLine("Rätt! Ett starkt ljus bländar dig och plingande ljud som vid ett tivoli ökar i styrka.");
                                    Console.WriteLine();
                                    return;
                                }
                                
                                else if (wordCode == "link the sims")
                                {
                                    Console.WriteLine("Rätt! Ett starkt ljus bländar dig och plingande ljud som vid ett tivoli ökar i styrka.");
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
                            case "2":
                                Console.WriteLine("Du fortsätter leta");
                                isRunning = false;
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Men kom igen! Svara 1, 2, 3 eller 4!");
                    break;
            }
        }   
    }
    public void Room3()
    {
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");                                                 //------------------------------------------------------------------                                                                           ------------------------------------------------------------------                              ------------------------------------------------------------------
        Console.WriteLine("        ‡              Ljud från flipperspel möter dig i dörren och du kliver in i en gammal spelarkad.               ‡ \n        ‡       Flipperspel står uppradade längs ena väggen och basketkorgar med rännor täcker väggen mitt emot.      ‡ \n        ‡                              Mitt i rummet står några bord med upplagda kort.                               ‡ \n        ‡  Dörren liksom i första rummet stängs bakom dig och den är nu låst. Nu behöver du hitta en annan väg ut...  ‡ ");
        Console.WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ReadLine();

        questionsgame.Add(new FreeText("Vad är RPG för typ av spel?\nA. Rollspel \nB. Online-spel \nC. Plattformsspel \nD. Arkadspel", "a"));

        Console.WriteLine("Tvärs över rummet ser du ännu ett lås och när du inspekterar det ser du att det \nåterigen krävs två ord för att öppna låset. Leta igenom rummet och se vad du kan hitta.");
        Console.WriteLine();
        Console.WriteLine("Vart i rummet vill du börja?");

        bool isLooping = true;
        while (isLooping)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("Vart vill du härnäst?");
            Console.WriteLine("1. Gå och kika på basketkorgarna.");
            Console.WriteLine("2. Gå fram och sätt dig vid BlackJack-bordet");
            Console.WriteLine("3. Gå fram till ett flipperspel");
            Console.WriteLine("4. Gå fram till dörren tvärs över rummet.");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Du närmar dig basketbollarna och testar kasta en boll");
                    Console.WriteLine("Tryck enter för att kasta");
                    Console.ReadLine();
                    Console.WriteLine("Bollen går i korgen men ingenting verkar hända..");
                    break;
                case "2":
                    Console.WriteLine("Nu ska vi spela BlackJack.. Tryck enter när du är redo.");
                    Console.WriteLine();
                    Console.ReadLine();
                    BlackJack blackJack = new BlackJack();
                    blackJack.PlayBlackJack();
                    break;
                case "3":
                    Console.WriteLine("Flipperspelet framför dig lyser upp när du kommer närmare och du trycker på knappen..");
                    for (int i = 0; i < questionsgame.Count;)
                    {
                        Console.WriteLine(questionsgame[4].QuestionText);
                        Console.Write("Ditt val: ");
                        string? userAns = Console.ReadLine();
                        if (questionsgame[4].CheckAnswer(userAns.ToLower()) == true)
                        {
                            Console.WriteLine("Rätt! Kom ihåg ordet nu.");
                            Console.WriteLine();
                            break;
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
                case "4":
                    Console.WriteLine("Du går fram till dörren och ser att du låset är likadant som i första rummet: Vad gör du?");
                    bool isRunning = true;

                    while (isRunning)
                    {
                        Console.WriteLine("1. Testa låset. ");
                        Console.WriteLine("2. Fortsätt leta");
                        string userInp = Console.ReadLine();

                        switch (userInp.ToLower())
                        {
                            case "1":
                                Console.Write("Skriv in två ord separerat med ett mellanslag: ");
                                string? wordCode = Console.ReadLine();
                                
                                if (wordCode == "packman rollspel")
                                {
                                    Console.WriteLine("Rätt! Du kommer ut ur rummen och är fri!");
                                    Console.WriteLine();
                                    Console.ReadLine();
                                    return;
                                }
                                
                                else if (wordCode == "rollspel packman")
                                {
                                    Console.WriteLine("Rätt! Du kommer ut ur rummen och är fri!");
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
                            case "2":
                                Console.WriteLine("Du fortsätter leta");
                                isRunning = false;
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Men kom igen! Svara 1, 2, 3 eller 4!");
                    break;
            }
        }
    }
}