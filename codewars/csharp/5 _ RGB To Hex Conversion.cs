//The rgb() method is incomplete. Complete the method so that passing in RGB decimal values will result in a hexadecimal representation being returned. The valid decimal values for RGB are 0 - 255. Any (r,g,b) argument values that fall out of that range should be rounded to the closest valid value.
//The following are examples of expected output values:
//Rgb(255, 255, 255) # returns FFFFFF
//Rgb(148, 0, 211) # returns 9400D3
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string Rgb(int r, int g, int b) => String.Join("", new List<int>(new int[] {r, g, b}).Select(t => Convert.ToString(((t < 0) ? 0 : (t > 255) ? 255 : t), 16).PadLeft(2, '0').ToUpper()).ToList());
}
