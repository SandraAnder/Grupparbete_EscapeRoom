using System.Runtime.InteropServices;

class Game
{
    bool isRunning = true;
    public void Play()
    {
        while(isRunning)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Välkommen!\nHoppas du kan svara på lite frågor. Du har 5 liv, använd dom väl! \nDet finns olika utmaningar med flera rum i vardera att klara av. \nVarje rum har olika svårighetsgrad. \nDu kommer även stå inför olika val. Se till att välja rätt annars förlorar du. Du ser några dörrar: \nTryck enter för att välja utmaning.");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Vart vill du gå?");
            Console.WriteLine("1. Dörren med en yxa i. (Krim)");
            Console.WriteLine("2. Dörren med en filmremsa. (Film)");
            Console.WriteLine("3. Dörren med en Pacman. (Spel)");
            Console.WriteLine("4. Dörren med en TP-pjäsen. (Allmänbildning)");
            Console.Write("Ditt val av dörr: ");

            string? roomChoice = Console.ReadLine();

            switch(roomChoice)
            {
                case "1":
                    ChallangeCrime crime = new ChallangeCrime();
                    crime.Room1();
                    crime.Room2();
                    crime.Room3();
                    break;
                case "2":
                    ChallangeFilm film = new ChallangeFilm();
                    film.Room1();
                    film.Room2();
                    film.Room3();
                    break;
                case "3":
                    ChallangeGames games = new ChallangeGames();
                    games.Room1();
                    games.Room2();
                    games.Room3();
                    break;
                case "4":
                    ChallangeKnowledge knowledge = new ChallangeKnowledge();
                    knowledge.Room1();
                    knowledge.Room2();
                    knowledge.Room3();
                    break;

            }


            

        }
    }
}