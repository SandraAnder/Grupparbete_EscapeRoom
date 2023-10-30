using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
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

    public string MCCorrectAnswer {get; set;}

    public MultipleChoice (string questiontext, string mCOption1, string mCOption2, string mCCorrectAnswer) : base (questiontext)
    {
        MCOption1 = mCOption1;
        MCOption2 = mCOption2;
        MCCorrectAnswer = mCCorrectAnswer;
    }
    public override bool CheckAnswer(string userAnswer)
    {
        if(userAnswer == MCCorrectAnswer)
            return true;
        else
            return false;
    }
}

class OneXTwo : Question
{
    public string One {get; set;}
    public string X {get; set;}
    public string Two {get; set;} 

    public string OXTCorrectAnswer {get; set;}
    
    public OneXTwo(string questiontext, string one, string x, string two, string oXTCorrectAnswer) :base (questiontext)
    {
        One = one;
        X = x;
        Two = two;
        OXTCorrectAnswer = oXTCorrectAnswer;
    }
    public override bool CheckAnswer(string userAnswer)
    {
        if(userAnswer == OXTCorrectAnswer)
            return true;
        else
            return false;
    }   //Måste vi verkligen ha en Checkanswer till varje??
}
