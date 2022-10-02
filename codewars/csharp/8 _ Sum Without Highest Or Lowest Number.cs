//Sum all the numbers of the array except the highest and the lowest element.
//If array is empty, null or None, or if only 1 Element exists, return 0.
//e.g. { 6, 2, 1, 8, 10 } => 16

using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers) {
      if (numbers == null || numbers.Length < 2) {return 0;};
      return numbers.Sum()-numbers.Max()-numbers.Min();    
    }
  }
