using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo1
{
    class Tyres
    {
        private int kilometerts;
        public void Drive(int km)
        {
            kilometerts += km;
        } 
        public bool IsRubbish()
        {
            if (kilometerts>=2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
