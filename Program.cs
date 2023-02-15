using System;

//Validar si el usuario existe o se debe registrar, y regisrarse
//Darle la bienvenida al usuario si existe
//Repetir hasta completar los 10

namespace restaurant10TablesReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "migue","","","","","","","","","" };
            int arrayCurrentIndex = 1;
            bool userType;
            Console.WriteLine("Welcome to the best restaurant in the world");
            while (true)
            {
                Console.WriteLine("Are you registered user? Write true, or false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if(userType == true)
                {
                    Console.WriteLine("Hello, you are a registered user, please enter your user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                }
            }
        }
    }
}
