using System.ComponentModel;

public class Room
{
    public string QuestionText {get; set;}
    
    public Room(string questiontext)
    {
        QuestionText = questiontext;
    }
}

class FreeText : Room
{
    public string? FreeTextAnswer {get; set;}

    public FreeText(string questiontext, string freeTextAnswer) : base(questiontext)
    {
        FreeTextAnswer = freeTextAnswer;
    }

}