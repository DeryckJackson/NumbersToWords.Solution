using System;

namespace NumbersToWords.Models
{
  public static class NumsToWords
  {
    private static string[] ones = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    private static string[] teens = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

    public static string OnesConverter(char digit)
    {
      if (digit == '0')
      {
        return "";
      }
      else
      {
        return ones[int.Parse(digit.ToString()) - 1];
      }
    }
    public static string TeensConverter(char digit)
    {
      return "twelve";
    }
  }
}

/*
199 => one hundred ninety-nine
199,199 => one hundred and ninety-nine thousand, one hundred ninety-nine
*/