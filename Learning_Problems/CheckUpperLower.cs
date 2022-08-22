using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Problems
{
    internal class CheckUpperLower
    {
        public void UpperLower()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine(ch + " is lowercase character");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " is uppercase character ");
            }
            else
            {
                Console.WriteLine(ch + " Yor entred Wrong something please go for cerrect it next time thankyou ");
            }

            Console.ReadLine();
        }
    }
}
