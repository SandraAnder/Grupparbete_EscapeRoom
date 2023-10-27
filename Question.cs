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
class MultipleChoice : Question
{
    public string MCOption1 {get; set;}
    public string MCOption2 {get; set;}
    public MultipleChoice (string questiontext, string mCOption1, string mCOption2) : base (questiontext)
    {
        MCOption1 = mCOption1;
        MCOption2 = mCOption2;
    }
}
