//There is an array with some numbers. All numbers are equal except for one. Try to find it!
//findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
//It’s guaranteed that array contains more than 3 numbers.
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> n)
  {
    List<int> numbers = n.ToList();
    numbers.Sort();
    if (numbers[0] == numbers[1]) {return numbers[numbers.Count-1];}
    else {return numbers[0];}
  }
}
