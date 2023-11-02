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
    // public string Clue {get; set;} Fixa så man kan lägga in ledtrådar!

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
    public string MCCorrectAnswer1 {get; set;}
    public string MCCorrectAnswer2 {get; set;}

    public MultipleChoice (string questiontext, string mCCorrectAnswer1, string mCCorrectAnswer2) : base (questiontext)
    {
        MCCorrectAnswer1 = mCCorrectAnswer1;
        MCCorrectAnswer2 = mCCorrectAnswer2;
    }
    public override bool CheckAnswer(string userAnswer)
    {
        if(userAnswer == MCCorrectAnswer1)
            return true;
        else if (userAnswer == MCCorrectAnswer2)
            return true;
        else
            return false;
    }
}
/*
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
*/