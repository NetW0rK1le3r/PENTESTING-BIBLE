//In a factory a printer prints labels for boxes. For one kind of boxes the printer has to use colors which, for the sake of simplicity, are named with letters from a to m.
//The colors used by the printer are recorded in a control string. For example a "good" control string would be aaabbbbhaijjjm meaning that the printer used three times color a, four times color b, one time color h then one time color a...
//Sometimes there are problems: lack of colors, technical malfunction and a "bad" control string is produced e.g. aaaxbbbbyyhwawiwjjjwwm.
//You have to write a function printer_error which given a string will output the error rate of the printer as a string representing a rational whose numerator is the number of errors and the denominator the length of the control string.
//e.g. s="aaaxbbbbyyhwawiwjjjwwm"   -->   error_printer(s) => "8/22"
using System;
public class Printer 
{
    public static string PrinterError(String s) 
    {
        int errorCount = 0;
        for (int i = 0; i < s.Length; i++) {
          if ("abcdefghijklm".IndexOf(s[i]) == -1) {
            errorCount += 1;
          }
        }
      return errorCount+"/"+s.Length;
    }
}
