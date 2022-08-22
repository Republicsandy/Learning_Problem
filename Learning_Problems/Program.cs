using System;

namespace Learning_Problems
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter the Number Which Program you want to Perform");
            Console.WriteLine("Press 1 for swap number");
            Console.WriteLine("Press 2 for check uppper or lower ");
            Console.WriteLine("Press 3 for Armstrong Number");
            Console.WriteLine("Press 4 for palindrom Number");
            int valueGet = Convert.ToInt32(Console.ReadLine());
            switch (valueGet)
            {
                case 1:
                    SwapNumber swapnumber = new SwapNumber();
                    swapnumber.SwapNum();
                    break;
                case 2:
                    CheckUpperLower upperlower = new CheckUpperLower();
                    upperlower.UpperLower();
                    break;
                case 3:
                    ArmstrongNubmer armstrong = new ArmstrongNubmer();
                    armstrong.Armstrong();
                    break;
                case 4:
                    PalindromNumber palindrom = new PalindromNumber();
                    palindrom.Palindrom();
                    break;
            }
        }
    }
}
