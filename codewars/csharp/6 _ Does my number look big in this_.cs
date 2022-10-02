//A Narcissistic Number is a number which is the sum of its own digits, each raised to the power of the number of digits in a given base. In this Kata, we will restrict ourselves to decimal (base 10).
//For example, take 153 (3 digits): 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
//Your code must return true or false depending upon whether the given number is a Narcissistic number in base 10.
using System;
public class Kata
{
  public static bool Narcissistic(int value)
  {
  string intString = value.ToString();
  int intLen = intString.Length;
  double sum = 0;
    for (int i=0; i < intLen; i++) {
      sum += Math.Pow(int.Parse(intString[i].ToString()), intLen);
    
    };
  return (sum == value);
  }
}
