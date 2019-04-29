//use the functionality from the MVC package that we got from the ASP.NET.
using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  //Class declaration, by adding : Controller to our HomeController class we tell .NET that HomeController would inherit or extend functionalty form ASP.NET
  public class HomeController : Controller
  {
    // Using just a / enables a shorter URL path.
    [Route("/")]
    //This will return HTML from our View/Home/MadLib.cshtml because our method corresponds with MadLib.cshtml
    // public string Hello(){ return "Please work!"; }


    public ActionResult MadLib(string noun1, string noun2, string noun3, string noun4, string noun5, string occupation, string place, string verbEd, string verb, string verbIng, string nounPlural, string emotion) {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.SetNoun1(noun1);
      myMadLibVariable.SetNoun2(noun2);
      myMadLibVariable.SetNoun3(noun3);
      myMadLibVariable.SetNoun4(noun4);
      myMadLibVariable.SetNoun5(noun5);
      myMadLibVariable.SetOccupation(occupation);
      myMadLibVariable.SetPlace(place);
      myMadLibVariable.SetVerbEd(verbEd);
      myMadLibVariable.SetVerb(verb);
      myMadLibVariable.SetVerbIng(verbIng);
      myMadLibVariable.SetNounPlural(nounPlural);
      myMadLibVariable.SetEmotion(emotion);
      return View(myMadLibVariable);
    }
    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}
