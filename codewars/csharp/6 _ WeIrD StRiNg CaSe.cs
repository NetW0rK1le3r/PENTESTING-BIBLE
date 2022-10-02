//Write a function toWeirdCase (weirdcase in Ruby) that accepts a string, and returns the same string with all even indexed characters in each word upper cased, and all odd indexed characters in each word lower cased. The indexing just explained is zero based, so the zero-ith index is even, therefore that character should be upper cased.
//The passed in string will only consist of alphabetical characters and spaces(' '). Spaces will only be present if there are multiple words. Words will be separated by a single space(' ').
//toWeirdCase( "String" );//=> returns "StRiNg"
//toWeirdCase( "Weird string case" );//=> returns "WeIrD StRiNg CaSe"
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static string ToWeirdCase(string s)
  {
    List<string> sSpl = s.Split().ToList();
    string sComp = "";
    foreach (string n in sSpl) {
      char[] nSpl = n.ToCharArray();
      for (int i=0;i<nSpl.Length;i++) {
          sComp += (i%2==0 ? nSpl[i].ToString().ToUpper():nSpl[i].ToString().ToLower());
      };
      sComp += " ";
    };
    return sComp.Substring(0, sComp.Length-1);
  }
}
