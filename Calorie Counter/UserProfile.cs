using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    class UserProfile
    {
        private string _userName;
        private string _userGender;
        private int _userAge;
        private int _userHeight;
        private int _userWeight;

        public UserProfile(string userName)
        {
            this._userName = userName;
        }

        public void PrintUser()
        {
            Console.WriteLine(_userName);

        }
    }
}
