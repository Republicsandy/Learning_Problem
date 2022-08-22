using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Problems
{
    public class ArmstrongNubmer
    {
        public void Armstrong()
        {
            int number, reminder, sum = 0, temp;
            Console.Write("Enter the Number= ");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + (reminder * reminder * reminder);
                number = number / 10;
            }
            if (temp == sum)
                Console.Write("Its Armstrong Number.");
            else
                Console.Write("Its Not Armstrong Number.");
        }
    }
}
