using System;
using System.Collections.Generic;

namespace FrenchNumberToWord.Objects
{
  public class NumberTranslator
  {
    private static string[] _numbers0To19 = new string[] { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"};
    private static string[] _doubleDigits = new string[] { "null", "void", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante", "quatre-vingt", "quatre-vingt"};
    private static string[] _largeNumbers = new string[] {"", "mille", "million", "milliard", "billion", "billiard", "trillion"};
    private int _id;
    private int _number;
    private static List<NumberTranslator> _instances = new List<NumberTranslator> {};

    public NumberTranslator(int userInput) {
      _instances.Add(this);
      _id = _instances.Count;
      _number = userInput;
    }

    public int GetNumber()
    {
      return _number;
    }

    public static List<NumberTranslator> GetAll()
    {
      return _instances;
    }

    public string Translate(int numberToTranslate)
    {
      bool addDash = false;
      bool addS = false;
      string output = "";
      string stringNumberToTranslate = numberToTranslate.ToString();
      int numberLength = stringNumberToTranslate.Length;
      int largeNamberIndex = (numberLength - 1) / 3;

      while (stringNumberToTranslate.Length % 3 != 0)
      {
          stringNumberToTranslate = "0" + stringNumberToTranslate;
      }

      while (largeNamberIndex >= 0)
      {
        addS = false;
        string toBeWorkingNumber = "";
        string toBeRemainder = "";
        for(int index = 0; index < stringNumberToTranslate.Length; index ++)
        {
          if (index < 3)
          {
            toBeWorkingNumber += stringNumberToTranslate[index];
          }
          else{
            toBeRemainder += stringNumberToTranslate[index];
          }
        }
        stringNumberToTranslate = toBeRemainder;
        int workingNumberToTranslate = int.Parse(toBeWorkingNumber);
        if (workingNumberToTranslate > 1 && largeNamberIndex > 1) addS = true;
        if (workingNumberToTranslate != 0 || output == "")
        {
          if (workingNumberToTranslate >= 100)
          {
            int hundredsNumber = workingNumberToTranslate / 100;
            if (hundredsNumber > 1)
            {
              output += _numbers0To19[hundredsNumber];
              output += " cents";
            }
            else
            {
              output += "cent";
            }
            workingNumberToTranslate = workingNumberToTranslate % 100;
            if (workingNumberToTranslate != 0) output += " ";
          }
          if (workingNumberToTranslate > 19)
          {
            addDash = true;
            int tensNumber = workingNumberToTranslate / 10;
            output += _doubleDigits[tensNumber];
            if (tensNumber == 7 || tensNumber == 9)
            {
              workingNumberToTranslate = (workingNumberToTranslate % 10) + 10;
            }
            else
            {
              workingNumberToTranslate = workingNumberToTranslate % 10;
            }
          }
          if (workingNumberToTranslate > 0 || output == "")
          {
            if (output != "" && addDash)
            {
              if (workingNumberToTranslate == 1) output += " et ";
              else output += "-";
            }
            output += _numbers0To19[workingNumberToTranslate];
          }
          output += " " + _largeNumbers[largeNamberIndex];
          if (addS) output += "s ";
          else output += " ";
        }
        if (largeNamberIndex > 1 && int.Parse(stringNumberToTranslate) > 0)
        {
          output += "de ";
        }
        largeNamberIndex --;
      }

      return output.Trim();

    }
  }
}
