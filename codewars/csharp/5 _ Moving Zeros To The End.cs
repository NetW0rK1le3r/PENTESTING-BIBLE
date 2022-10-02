//Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
//Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int zeros = 0;
    List<int> intList = new List<int>();
    for (int i=0; i < arr.Length; i++) {
      if (arr[i] != 0) {
        intList.Insert(0+zeros, arr[i]);
      } else {
        zeros++;
        intList.Insert(0, arr[i]);
      }
    }
    intList.Reverse();
    return intList.ToArray();
  }
}
