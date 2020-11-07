using _03.Telephony.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ICallAllNumbers, IBrowseAllSites
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                // невалиден сайт(по условие) - съдържа символ цифра
                throw new InvalidUrlException(); // съобщението ще дойде от using _03.Telephony.Exceptions
            }

            return $"Browsing: {url}!";
        }

        public string Call(string phoneNummer)
        {
            if (!phoneNummer.All(x => char.IsDigit(x)))
            {
                // невалиден номер - съдържа символ различен от цифра
                throw new InvalidPhoneException(); // съобщението ще дойде от using _03.Telephony.Exceptions
            }

            return $"Calling... {phoneNummer}";
        }
    }
}
