//Your task is to write a function maskify, which changes all but the last four characters into '#'.
//Kata.Maskify('4556364607935616'); // should return "############5616"
//Kata.Maskify('1');                // should return "1"
//Kata.Maskify('');                 // should return ""
using System.Linq;
public static class Kata
{
  public static string Maskify(string cc)
  {
   return cc.Length < 4 ? cc : string.Concat(Enumerable.Repeat("#",(cc.Length-4)))+cc.Substring(cc.Length-4);
  }
}
