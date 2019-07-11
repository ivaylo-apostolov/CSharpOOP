using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browsing(string siteAddress)
        {
            if (Regex.IsMatch(siteAddress, @"^[\D\:\/\.]+$"))
            {
                return $"Browsing: {siteAddress}!";
            }

            return "Invalid URL!";
        }

        public string Calling(string number)
        {
            if (Regex.IsMatch(number, @"^[\d]+$"))
            {
                return $"Calling... {number}";
            }

            return "Invalid number!";
        }
    }
}
