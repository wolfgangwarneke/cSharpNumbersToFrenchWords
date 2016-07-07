using Nancy;
using System;
using FrenchNumberToWord.Objects;
using System.Collections.Generic;

namespace FrenchNumberToWord
{
  public class HomeModule : NancyModule
  {

    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        NumberTranslator.ClearAll();
        int howManyMoreTimes = Request.Form["amount"];
        Random random = new Random();
        for (int i = 0; i < howManyMoreTimes; i ++)
        {
          NumberTranslator modelTranslator = new NumberTranslator(random.Next(0, Request.Form["max"]));
        }
        List<NumberTranslator> numbersGenerated = NumberTranslator.GetAll();
        return View["index.cshtml", numbersGenerated];
      };
    }
  }
}
