using _03.Telephony.Exceptions;
using System;
using System.Collections.Generic;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inNumbers = Console.ReadLine().Split();
            string[] inSites = Console.ReadLine().Split();

            StationaryPhone sPhone = new StationaryPhone();
            Smartphone smartPhone = new Smartphone();

            for (int i = 0; i < inNumbers.Length; i++)
            {
                try
                {
                    if (inNumbers[i].Length == 7)
                    {
                        Console.WriteLine(sPhone.Call(inNumbers[i]));
                    }
                    else if(inNumbers[i].Length == 10)
                    {
                        Console.WriteLine(smartPhone.Call(inNumbers[i]));
                    }
                    else
                    {
                        throw new InvalidPhoneException();
                    }
                }
                catch (InvalidPhoneException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < inSites.Length; i++)
            {
                try
                {
                    Console.WriteLine(smartPhone.Browse(inSites[i]));
                }
                catch (InvalidUrlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
