using System;
using System.Collections.Generic;

namespace FrenchNumberToWord
{
  public class NumberTranslator
  {
    public string Translate(int numberToTranslate)
    {
      if (numberToTranslate == 0) return "zéro";
      return "failed input";
    }
  }
}
