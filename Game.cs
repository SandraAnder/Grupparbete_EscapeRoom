class Game
{
    bool isRunning = true;
    public void Play()
    {
        while(isRunning)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Välkommen!\nHoppas du kan svara på lite frågor. Du har 5 liv, använd dom väl! \nDet finns flera olika rum att klara av. Varje rum har olika svårighetsgrad. \nDu kommer även stå inför olika val. Se till att välja rätt annars förlorar du. \n\nTill höger om dig ser du en dörr med en yxa i. Tryck enter för att öppna dörren.");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
            Challange1 room = new Challange1();
            room.Room1();
            room.Room2();

        }
    }
}