/*A stream of data is received and needs to be reversed. Each segment is 8 bits meaning the order of these segments need to be reversed:
11111111 00000000 00001111 10101010
(byte1) (byte2) (byte3) (byte4)
10101010 00001111 00000000 11111111
(byte4) (byte3) (byte2) (byte1)
Total number of bits will always be a multiple of 8. The data is given in an array as such:
[1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0]
*/
using System.Collections.Generic;
using System.Linq;

namespace Main{

using System;
public class Kata
{
  public static int[] DataReverse(int[] data) => String.Concat(Split(String.Concat(data), 8).Reverse()).ToCharArray().Select(n => int.Parse(n.ToString())).ToArray();

  static IEnumerable<string> Split(string str, int chunkSize) {return Enumerable.Range(0, str.Length / chunkSize).Select(i => str.Substring(i * chunkSize, chunkSize));}
}
}
