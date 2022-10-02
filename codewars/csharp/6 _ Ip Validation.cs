//Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.
//Note that leading zeros (e.g. 01.02.03.04) are considered invalid.
using System.Text.RegularExpressions;

namespace Solution {
class Kata
  {
    public static bool is_valid_IP(string IpAddress)
    {
        string[] ipParts = IpAddress.Split('.');
        if (ipParts.Length != 4 || Regex.IsMatch(IpAddress.Replace(".",""), @"^[a-zA-Z]+$") || IpAddress.Contains(" ") == true) {return false;};
        for (int i=0; i < 4; i++) {
          int n = int.Parse(ipParts[i]);
          if (n < 0 || n > 255 || n % 1 != 0 || ipParts[i].TrimStart('0') != ipParts[i]) {return false;};
      }
        return true;
    }
  }
}
