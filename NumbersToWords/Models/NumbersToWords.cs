using System;

namespace NumbersToWords.Models
{
  public static class NumsToWords
  {
    public static string OnesConverter(char digit)
    {
      string[] ones = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
      if (digit == '0')
      {
        return "";
      }
      else
      {
        return ones[int.Parse(digit.ToString()) - 1];
      }
    }
  }
}