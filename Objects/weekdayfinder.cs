using System;
using System.Collections.Generic;

namespace FrenchNumberToWord
{
  public class NumberTranslator
  {
    private string[] _numbers0To19 = new string[] { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"};
    private string[] _doubleDigits = new string[] { "null", "void", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante", "quatre-vingt", "quatre-vingt"};
    public string Translate(int numberToTranslate)
    {
      bool addDash = false;
      string output = "";
      if (numberToTranslate >= 100)
      {
        int hundredsNumber = numberToTranslate / 100;
        if (hundredsNumber > 1)
        {
          output += _numbers0To19[hundredsNumber];
          output += " cents";
        }
        else
        {
          output += "cent";
        }
        numberToTranslate = numberToTranslate % 100;
        if (numberToTranslate != 0) output += " ";
      }
      if (numberToTranslate > 19)
      {
        addDash = true;
        int tensNumber = numberToTranslate / 10;
        output += _doubleDigits[tensNumber];
        if (tensNumber == 7 || tensNumber == 9)
        {
          numberToTranslate = (numberToTranslate % 10) + 10;
        }
        else
        {
          numberToTranslate = numberToTranslate % 10;
        }
      }
      if (numberToTranslate > 0 || output == "")
      {
        if (output != "" && addDash)
        {
          if (numberToTranslate == 1) output += " et ";
          else output += "-";
        }
        output += _numbers0To19[numberToTranslate];
      }
      return output;
    }
  }
}
