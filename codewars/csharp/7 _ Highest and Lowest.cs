//In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
//Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    int[] numarray = numbers.Split(" ").Select(n => Convert.ToInt32(n)).ToArray();
    return numarray.Max()+" "+numarray.Min();
  }
}
