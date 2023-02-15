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
                if(arrayCurrentIndex == 10)
                {
                    Console.WriteLine("The restaurant is full, try again next year");
                    Environment.Exit(0);
                }
                Console.WriteLine("Are you registered user? Write true, or false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if(userType == true)
                {
                    Console.WriteLine("Hello, you are a registered user, please enter your user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, it's a pleasure to give you food", userNames[index]);
                    }
                }
                else if(userType == false)
                {
                    Console.WriteLine("please write and remember your User Name");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your user has been successfully\n" + "your user Name is {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
        }
    }
}
