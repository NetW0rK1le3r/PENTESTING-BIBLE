//Your task is to write a function that takes a string and return a new string with all vowels removed.
//For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
using System;
using System.Linq;
public static class Kata
{
  public static string Disemvowel(string str)
  {
    for (int i=0; i < str.Length; i++) {
      if ("aeiouAEIOU".IndexOf(str[i]) != -1) {str = str.Remove(i, 1);i--;};
    }
    return str;
  }
}
