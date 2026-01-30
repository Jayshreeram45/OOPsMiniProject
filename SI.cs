using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsMiniProject
{
    internal class SI
    {
        Double Principal, interest,SimpleInterest;
        int time;
        internal SI(double principal,double interest,int Time)
        {
            Principal = principal;
            this.interest = interest;
            time = Time;
        }
        internal void CalculateSI()
        {
            SimpleInterest = (Principal * interest * time)/100;
        }
        internal void Display()
        {
            Console.WriteLine("SimpleInterest is {0}", SimpleInterest);
        }
    }
}
