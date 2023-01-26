using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Encapsulation
    {
        public void GetUsernamePassword()
        {
            MemberControl member = new MemberControl();
            member.UserName = "hasantabanli*-/";
            member.Password = "123456";

            Console.WriteLine("User Name : {0} - Password: {1}", member.UserName, member.Password);

            Console.Read();
        }
    }

    class MemberControl
    {
        private string _username;
        private string _password;

        public string UserName
        {
            get
            {
                return _username;
            }

            set
            {
                //Control characters.
                bool isOK = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        isOK = false;
                        break;
                    }
                }
                if (isOK)
                {
                    _username = value;
                }
                else
                {
                    throw new ArgumentException("Username cannot have a character except letter");
                }
            }
        }

        public string Password
        {

            get { return _password; }
            set { _password = value; }
        }

    }
}
