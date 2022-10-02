//Write function avg which calculates average of numbers in given list.
using System.Linq;
class AverageSolution
{
  public static double FindAverage(double[] array) => array.Length < 1 ? array.Sum() : array.Sum()/array.Length;
} 
