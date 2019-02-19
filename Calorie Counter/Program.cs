using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    class Program
    {
        static void Main()
        {
            string userName ;
            string userGender;
            int userAge;
            int userHeight;
            int userWeight;

            Console.WriteLine("Tell me about yourself by filling in some information please: ");

            Console.WriteLine("First, can you tell me your name?");
            userName = Console.ReadLine();

            Console.WriteLine("Nice to meet you " + userName + ". Next, if you're comfortable sharing, can you tell me your sex.");
            userGender = Console.ReadLine(); 

            Console.WriteLine("Alirghty, just a few more questions and we are done with your profile. What's your age");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So you are " + userAge + " years old. Cool, what is your height in inches?");
            userHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nice, so last thing. How much do you weigh?");
            userWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thanks for the info. Does this look correct to you?");
            Console.WriteLine(userName + userGender + userAge + userHeight + userWeight);
        }
    }
}
