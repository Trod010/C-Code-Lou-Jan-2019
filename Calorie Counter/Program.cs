using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calorie_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            userName();
            sexCheck();
            userAge();
            userHeight();
            userWeight();
        }
        // Asking for username 
        private static void userName()
        {
            Console.WriteLine("Hi there. Can you tell me your first name? \n");
            string firstName = Console.ReadLine();
            Console.WriteLine("Cool beans, what's your last name? \n");
            string lastName = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + firstName + " " + lastName + "! \n");
            
        }
        //checking gender 
        private static void sexCheck (bool onlyLetters = false)
        {
            Console.WriteLine("Next, are you male or female? \n");
            string userSex = Console.ReadLine();

            for(var i = 0; i < userSex.Length; i++)
            {
                if (userSex == "male" || userSex == "Male" || userSex == "female" || userSex == "Female")
                {
                    onlyLetters = true;
                    Console.WriteLine("So you are a " + userSex + ". \n");
                    break;
                }
                else
                {
                    onlyLetters = false;
                }
                if (onlyLetters == false)
                {
                    Console.WriteLine("Please enter a valid response. \n");
                    sexCheck();
                }
            }
        }

        private static void userAge()
        {
            Console.WriteLine("Can you tell me how old you are?");
            string inputAge = Console.ReadLine();
            try
            {
                int age = Int32.Parse(inputAge);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a number.");
            }
        }

        private static void userHeight()
        {
            Console.WriteLine("Now then, how tall are you in inches?");
            string inputHeight = Console.ReadLine();
        }

        private static void userWeight()
        {
            Console.WriteLine("Lastly, can you tell me how much you weight in pounds?");
            string inputWeight = Console.ReadLine();
        }
    }
}
