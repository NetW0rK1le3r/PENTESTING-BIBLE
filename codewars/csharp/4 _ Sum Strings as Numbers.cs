//Sidenote: This kata is on rank 4 because we had to figure out that the errors thrown were due to massive numbers being given as inputs, as well as empty strings.
//Given the string representations of two integers, return the string representation of the sum of those integers.
//sumStrings('1','2') // => '3'
using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b) => a == "" ? b : (BigInteger.Parse(a)+BigInteger.Parse(b)).ToString();
}
