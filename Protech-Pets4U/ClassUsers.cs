using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protech_Pets4U
{
    class ClassUsers
    {
        private string typeUser;
        private string name;
        private string lastName;
        private string userName;
        private string password;
        private string question;
        private string answer;

        public ClassUsers(string TypeUser, string Name, string LastName, string UserName, string Password, string Question, string Answer)
        {
            typeUser = TypeUser;
            name = Name;
            lastName = LastName;
            userName = UserName;
            password = Password;
            question = Question;
            answer = Answer;
        }

        public string getName()
        {
            return name;
        }

        public string getQuestion()
        {
            return question;
        }

        public string getAnswer()
        {
            return answer;
        }

        public string getTypeUser()
        {
            return typeUser;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getUserName()
        {
            return userName;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
