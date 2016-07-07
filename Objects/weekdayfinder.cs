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
      string output = "";
      if (numberToTranslate > 19)
      {
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
        if (output != "")
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
