using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : ICallAllNumbers
    {
        public string Call(string phoneNummer)
        {
            if (!phoneNummer.All(x=> char.IsDigit(x)))
            {
                // невалиден номер - съдържа символ различен от цифра
                throw new InvalidPhoneException(); // съобщението ще дойде от using _03.Telephony.Exceptions
            }

            return $"Dialing... {phoneNummer}";
        }
    }
}
