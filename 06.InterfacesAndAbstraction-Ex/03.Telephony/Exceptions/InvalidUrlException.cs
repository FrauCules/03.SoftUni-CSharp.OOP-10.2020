using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Exceptions
{
    public class InvalidUrlException : Exception
    {
        private const string INLALID_URL_EXCEPTION_MESSAGE = "Invalid URL!";
        public InvalidUrlException()
            :base (INLALID_URL_EXCEPTION_MESSAGE)
        {

        }
    }
}
