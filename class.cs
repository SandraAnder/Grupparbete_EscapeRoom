using System.ComponentModel;

public class Question
{
    public string QuestionText {get; set;}
    
    public Question(string questiontext)
    {
        QuestionText = questiontext;
    }
}

class FreeText : Question
{
    public string? FreeTextAnswer {get; set;}

    public FreeText(string questiontext, string freeTextAnswer) : base(questiontext)
    {
        FreeTextAnswer = freeTextAnswer;
    }

}