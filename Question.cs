using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Question
{
    public string QuestionText {get; set;}
    
    public Question(string questiontext)
    {
        QuestionText = questiontext;
    }
    public virtual bool CheckAnswer(string userAnswer)
    {
        return true;
    }
}

class FreeText : Question
{
    public string? FreeTextAnswer {get; set;}

    public FreeText(string questiontext, string freeTextAnswer) : base(questiontext)
    {
        FreeTextAnswer = freeTextAnswer;
    }
    public override bool CheckAnswer(string userAnswer)
    {
        if(userAnswer == FreeTextAnswer)
            return true;
        else
            return false;
    }
}

