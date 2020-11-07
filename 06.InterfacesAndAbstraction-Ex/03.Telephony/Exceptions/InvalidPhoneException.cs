using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class InvalidPhoneException: Exception
    {
        private const string INLALID_PHONE_NUMBER_EXCEPTION_MESSAGE = "Invalid number!";
        public InvalidPhoneException()
            : base(INLALID_PHONE_NUMBER_EXCEPTION_MESSAGE)
        {

        }
    }
}
 