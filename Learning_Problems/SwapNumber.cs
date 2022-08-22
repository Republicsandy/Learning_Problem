using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Problems
{
    class SwapNumber
    {
        public void SwapNum()
        {
           // int firstNumber = 10;
            //int secondNumber = 5;

            Console.WriteLine("Enter the firstNumber:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secondNumber:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

           
            firstNumber = firstNumber + secondNumber; //  now becomes 50
            secondNumber = firstNumber - secondNumber; //  becomes 10
            firstNumber = firstNumber - secondNumber; //  becomes 5

            Console.WriteLine("After swaping:" + " firstNumber = " + firstNumber + ", secondNumber = " + secondNumber);
        }
    }
}
