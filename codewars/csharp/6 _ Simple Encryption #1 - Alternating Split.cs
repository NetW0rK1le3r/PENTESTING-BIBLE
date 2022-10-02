/*For building the encrypted string:
Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
Do this n times!
Examples:
"This is a test!", 1 -> "hsi  etTi sats!"
"This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"
Write two methods:

string Encrypt(string text, int n)
string Decrypt(string encryptedText, int n)
*/
using System.Linq;
using System;
public class Kata
{
  public static string Encrypt(string text, int n)
  {
    if (text == null) {return null;};
    for (int c=0; c < n; c++) {
      text = String.Join("",text.ToCharArray().ToList().Where((s,i) => i % 2 != 0))+String.Join("",text.ToCharArray().ToList().Where((s,i) => i % 2 == 0));
    };
    return text;
  }
  
  
  public static string Decrypt(string text, int n)
  {
  string finished = "";
  for (int c=0;c<n;c++) {
    string firstHalf = text.Substring(0,text.Length/2);
    string secondHalf = text.Substring(text.Length/2, (text.Length/2)+(text.Length%2==0?0:1));
    for (int i=0;i<text.Length;i++) {
      if (i%2!=0) {
        finished+=firstHalf[0];
        firstHalf = firstHalf.Substring(1);
      } else {
        finished+=secondHalf[0];
        secondHalf = secondHalf.Substring(1);
      }
    }
    text = finished;
    finished = "";   
  }
  return text;
  }
}
