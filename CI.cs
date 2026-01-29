using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsMiniProject
{
    internal class CI
    {
        Double Amount, Principal,CompoundInterest;
        int Interest, Time;
        internal CI(double Principal, int Interest, int Time)
        {
            this.Principal = Principal;
            this.Interest = Interest;
            this.Time = Time;
        }
        internal void CalculateTotalAmount()
        {
            Amount = Principal * Math.Pow((1 + (Interest / 100.0)), Time);
            Console.WriteLine("Total Amount = {0}", Amount.ToString("0.00"));
        }
        internal void CalculateCI()
        {
            CompoundInterest = Amount - Principal;
            Console.WriteLine("CompoundInterest = {0}", CompoundInterest.ToString("0.00"));
        }
    }
}
