using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Problems
{
    class PalindromNumber
    {
        public void Palindrom()
        {
            int number, reminder, sum = 0, temp;
            
            Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            Console.Write("\n Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                reminder = number % 10; //for getting remainder by dividing with 10    
                number = number / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + reminder;  //multiplying the sum with 10 and adding remainder
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
        }
    }
}
