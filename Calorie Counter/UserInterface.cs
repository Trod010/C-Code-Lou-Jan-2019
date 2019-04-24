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

        private void ShowUser(string name)
        {
            List<UserProfile> userProfiles = storedData.FindUser(name);
            foreach (UserProfile user in userProfiles)
                Console.WriteLine(user);
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

        public void SearchUser()
        {
            string userName = Console.ReadLine();
            List<UserProfile> userProfiles = storedData.FindUser(userName);
            if(userProfiles.Count() > 0)
            {
                Console.WriteLine("Found user!");
                foreach (UserProfile user in userProfiles)
                    Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void DeleteUser()
        {
            Console.WriteLine("The user profile will be deleted.");
            string userName = Console.ReadLine();
            storedData.DeleteUser(userName);
        }

        public void HomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Hey there. Welcome to your virtual calorie counter.");
            Console.WriteLine("The time is {0}", DateTime.Now);
        }
    }
}
