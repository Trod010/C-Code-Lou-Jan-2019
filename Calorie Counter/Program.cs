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
        //const string filePath = @"C:\Users\punch\Documents\ProfileData.txt"; not found on this device. check laptop

        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            char choice = '0';

            while(choice !='4')
            {
                userInterface.HomeScreen();
                Console.WriteLine();
                Console.WriteLine("Choose an action");
                Console.WriteLine("1 - Add a user");
                Console.WriteLine("2 - Search for users");
                Console.WriteLine("3 - Delete users");
                Console.WriteLine("4 - Exit");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        userInterface.AddUser();
                        break;
                    case '2':
                        userInterface.SearchUser();
                        break;
                    case '3':
                        userInterface.DeleteUser();
                        break;
                    case '4':
                        Console.WriteLine("Press any key to end the program.");
                        break;
                    default:
                        Console.WriteLine("Error, please use the appropriate key to proceed.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
