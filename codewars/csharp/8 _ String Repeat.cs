//Write a function called repeatStr which repeats the given string string exactly n times.
using System;
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      string rep = "";
      for (int i=0; i < n; i++) {rep += s;}
      return rep;
    }
  }
}
