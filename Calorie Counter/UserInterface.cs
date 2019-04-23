using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    class UserInterface
    {
        private StoredData storedData;

        public UserInterface()
        {
            storedData = new StoredData();
        }

        public void AddUser()
        {
            Console.WriteLine("Hi there. Can you tell me your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your sex? Are you female or male?");
            string gender = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How tall are you in inches?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much do you weigh in pounds?");
            int weight = Convert.ToInt32(Console.ReadLine());
            storedData.AddUser(name, gender, age, height, weight);
        }



    }
}
