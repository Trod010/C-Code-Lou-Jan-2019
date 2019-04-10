using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    public class StoredData
    {
        private List<UserProfile> userProfiles;

        public StoredData()
        {
            userProfiles = new List<UserProfile>();
        }

        public void AddUser(string name, string gender, int age, int height, int weight)
        {
            userProfiles.Add(new UserProfile(name, gender, age, height, weight));
        }

        public List<UserProfile> FindUser(string name)
        {
            List<UserProfile> found = new List<UserProfile>();
            foreach(UserProfile user in userProfiles)
            {
                user.Name = name;
            }
            return found;
        }

        public void DeleteUser(string name)
        {
            List<UserProfile> found = new List<UserProfile>();
            foreach (UserProfile user in userProfiles)
                userProfiles.Remove(user);
        }
    }
}
