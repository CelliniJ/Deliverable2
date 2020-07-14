using System;
using System.Diagnostics.CodeAnalysis;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your message?:");

            string input;
            input = Console.ReadLine();
            string upper;
            upper = input.ToUpper();
            int n, checksum = 0;
            string message;
            message = "";


            foreach (char c in upper)
            {
                message += Convert.ToInt32(c)-64 + "-";      
            }
            ;

            foreach (char c in upper)
            {
                n = Convert.ToInt32(c);
                checksum += n;
            }
            ;


            Console.WriteLine("Your encoded message is " + message + ".");
            Console.WriteLine("Message checksum is " + checksum + ".");
        }
    }     
 }