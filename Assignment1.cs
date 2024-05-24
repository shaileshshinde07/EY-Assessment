using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    internal class Assignment1
    {
        public class Authentication
        {
            
            public bool Login(string username, string password)
            {
                bool isLogin = false;

                if (!isLogin)
                {
                    if (username == "shailesh" && password == "admin")
                    {
                        isLogin = true;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Login Failed, Please check the username or password");
                        return isLogin;
                    }
                }
                else
                {
                    Console.WriteLine("User already Logged in");
                    return true;
                }

            }
        }
        class Products
        {
            public int productId { get; set; }
            public string productName { get; set; }
            public double productPrice { get; set; }
            public string productDescription { get; set; }
            public int productQuantity { get; set; }

        }
        internal class FinalAssignment
        {
            public void Main()
            {
                Console.WriteLine("Home Page");

                Console.WriteLine("Press 1 to Login");
                Console.WriteLine("Press 2 for Registraction");

                string action = Console.ReadLine();

                if (action == "2")
                {
                    Console.WriteLine("Registrations Closed!");
                }
                else
                {
                    Authentication login = new Authentication();

                    Console.WriteLine("Enter Username");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();

                }
            }
        }
    }
}
