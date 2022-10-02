//An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    for (int i=0; i < 26; i++) {
      if (str.Length - (str.ToLower()).Replace("abcdefghijklmnopqrstuvwxyz"[i].ToString(),"").Length > 1)
        return false;
    }
    return true;
  }
}
