using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calorie_Counter
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public UserProfile(string name, string gender, int age, int height, int weight)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("User Data: \n\tName: {0}," +
                "                            \n\tGender: {1}, " +
                "                            \n\tAge: {2}, " +
                "                            \n\tHeight: {3}, " +
                "                            \n\tWeight: {4}",
                                 Name, Gender, Age, Height, Weight);
        }
    }
}
