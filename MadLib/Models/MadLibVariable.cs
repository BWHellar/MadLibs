namespace MadLib.Models
{
  public class MadLibVariable
  {
    //this creates a private string
    private string _noun1;
    private string _noun2;
    private string _noun3;
    private string _noun4;
    private string _noun5;
    private string _occupation;
    private string _verb;
    private string _place;
    private string _verbEd;
    private string _verbIng;
    private string _nounPlural;
    private string _emotion;
    //Since string is private we use a getter method to retrieve it
    public string GetNoun1()
    {
      return _noun1;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetNoun1(string newNoun1)
    {
      _noun1 = newNoun1;
    }
    public string GetNoun2()
    {
      return _noun2;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetNoun2(string newNoun2)
    {
      _noun2 = newNoun2;
    }
    public string GetNoun3()
    {
      return _noun3;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetNoun3(string newNoun3)
    {
      _noun3 = newNoun3;
    }
    public string GetNoun4()
    {
      return _noun4;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetNoun4(string newNoun4)
    {
      _noun4 = newNoun4;
    }
    public string GetNoun5()
    {
      return _noun5;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetNoun5(string newNoun5)
    {
      _noun5 = newNoun5;
    }
    public string GetOccupation()
    {
      return _occupation;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetOccupation(string newOccupation)
    {
      _occupation = newOccupation;
    }
    public string GetVerb()
    {
      return _verb;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
    }
    public string GetVerbEd()
    {
      return _verbEd;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetVerbEd(string newVerbEd)
    {
      _verbEd = newVerbEd;
    }
    public string GetPlace()
    {
      return _place;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }
    public string GetVerbIng()
    {
      return _verbIng;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetVerbIng(string newVerbIng)
    {
      _verbIng = newVerbIng;
    }
    public string GetNounPlural()
    {
      return _nounPlural;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetNounPlural(string newNounPlural)
    {
      _nounPlural = newNounPlural;
    }
    public string GetEmotion()
    {
      return _emotion;
    }
    //this setter method is used so we can change what is displays as necessary.
    public void SetEmotion(string newEmotion)
    {
      _emotion = newEmotion;
    }
  }
}
