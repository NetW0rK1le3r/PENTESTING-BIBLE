/*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.*/
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int Solution(int v) => Enumerable.Range(0,v).Where(n=>n%3==0 || n%5==0).Sum(n => n);
}
