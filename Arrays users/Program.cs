using System;

using System.Linq;

using System.Text;



namespace Practice

{

    class Program

    {

        static void Main(string[] args)

        {

            //arrays containing usernames and passwords

            string[] users = new string[] { "user1", "user2", "user3", "user4", "user5" };

            string[] passwords = new string[] { "pass1", "pass2", "pass3", "pass4", "pass5" };

            int tries = 0; //contains tries to be able to stop program if it exceeds 3 

            //prompts user for username and stores it in a string

            Console.WriteLine("Input username");

            string userInput = Console.ReadLine();

            //loops through arrays

            for (int i = 0; i < users.Length; i++)

            {   //checks username

                if (userInput == users[i])

                {

                    while (tries < 3)

                    {

                        Console.WriteLine("Input password");

                        string passInput = Console.ReadLine();

                        //checks password

                        if (passInput == passwords[i])

                        {

                            Console.WriteLine("Access granted");

                            tries = 3; //sets tries to 3 to stop program

                        }

                        else

                        {

                            Console.WriteLine("Wrong username or password, please try again");

                            tries++; //adds 1 to number of tries if username or password is incorrect to keep track

                        }

                    }

                }

            }

            Console.ReadKey(); //keeps console up

        }

    }

}