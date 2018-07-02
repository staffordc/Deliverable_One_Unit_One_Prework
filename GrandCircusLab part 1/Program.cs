using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //message for inputs

            Console.WriteLine("Let's play a number game! Give me a number with at least three digits");
            var UserNumber1 = Console.ReadLine();
            Console.WriteLine("Wow! That's a good number! Could you give me a number with the same amount of digits?");
            var UserNumber2 = Console.ReadLine();
            //check if numbers
            int ii;
            bool UserNumberisANumber = int.TryParse(UserNumber1 + UserNumber2, out ii);
            //check length
            bool UserNumberLengthEqual = (UserNumber1.Length == UserNumber2.Length);
            {
                if (UserNumberisANumber == true)
                {
                    
                }
                else if (UserNumberisANumber == false)
                {
                    Console.WriteLine("Wait a second! At least one of these was not a number, try again after I take a nap!");
                    Console.ReadLine();
                    return;
                }
            }
            {
                if (UserNumberLengthEqual == true)
                {
                    Console.WriteLine("Let me calculate what each place adds up to");
                }
                else if (UserNumberLengthEqual == false)
                {
                    Console.WriteLine("Wait a second! At least one of these numbers was different in length, try again after I take a nap!");
                    Console.ReadLine();
                    return;
                }
            }
            bool areEqual = Calculating(UserNumber1, UserNumber2);
            Console.WriteLine(areEqual);
            Console.WriteLine("If you want a answer in the positive try to make all places add up equally. Please wait until after my nap to try again!");
            Console.ReadLine();
        }

        //Calculating if equal
        private static bool Calculating(string UserNumber1, string UserNumber2)
        {
            //inputs separated by place
            var charArray1 = UserNumber1.ToCharArray();
            var charArray2 = UserNumber2.ToCharArray();

            //inputs place add for each corresponding place
            var charArray3 = new int[charArray1.Length];

            for (int i = 0; i < charArray1.Length; i++)
            {
                char cA1 = charArray1[i];
                int icA1 = int.Parse(cA1.ToString());
                char cA2 = charArray2[i];
                int icA2 = int.Parse(cA2.ToString());
                int cA3 = icA1 + icA2;
                charArray3[i] = cA3;
                Console.WriteLine(cA3);

            }

            //boolean for if both places equal the same solution
            Console.WriteLine("Now that the digits are added together I will see if the results are equal:");
            bool areEqual = charArray3.Distinct().Count() == 1;
            return areEqual;
        }
    }
}
