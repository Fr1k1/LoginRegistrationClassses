using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginRegistrationClassses
{
    internal class UsersRepository
    {

        public static List<Users> users = new List<Users>
        {
            new Users
            {
                firstname = "Ivan",
                lastname = "Ivic",
                username = "iivic",
                password = "1234",
            },

            new Users
            {
                firstname = "Josip",
                lastname = "Joza",
                username = "jjoza",
                password = "5678",
            },

            new Users
            {
                firstname = "Miroslav",
                lastname = "Ilic",
                username = "milic",
                password = "1234",
            },
        };

        public static bool ReturnUsers(string name, string password)
        {
            foreach (Users users in users)
            {
                if (users.username == name)
                {


                    if (users.password == password)
                    {
                        MessageBox.Show("User " + users.firstname + " " + users.lastname + " is succesfully Logged in!");
                        return true;
                    }
                }

            }
            MessageBox.Show("Entered credentials are not valid!");
            return false;
        }

        public static List<Users> RegisterUser(string firstname, string lastname, string username, string password)
        {

            Users user = new Users();

            user.firstname = firstname;
            user.lastname = lastname;
            user.username = username;
            user.password = password;

            users.Add(user);
            MessageBox.Show("Korisnik uspjesno dodana");

            return users;
        }
    }
}
