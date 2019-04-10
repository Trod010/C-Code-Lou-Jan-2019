using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    public class StoredData
    {

        private List<UserProfile> userProfiles = new List<UserProfile>();

        public void AddUser(string name, string gender, int age, int height, int weight)
        {
            userProfiles.Add(new UserProfile(name, gender, age, height, weight));
        }

        public List<UserProfile> FindUser(string name, bool foundUser)
        {
            List<UserProfile> found = new List<UserProfile>();

        }
    }
}
