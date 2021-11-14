using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The Reversed num is : " + rev);
        }
    }
}