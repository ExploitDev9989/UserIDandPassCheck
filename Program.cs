using System;

namespace UserIDandPassCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get input
            Console.WriteLine("===== Create A User ID and Password =====\n\n");
            Console.WriteLine("Please create a User ID: \n");
            string userID = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please create a Password:");
            string password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\n===== User ID and Password Created Successfully =====");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //do work
            bool loggedIn = false;
            int userattempts = 0;
            while (userattempts < 3)
            {
                Console.WriteLine("Enter your User ID: ");
                string username = Console.ReadLine();
                if (username != userID)
                {
                    userattempts++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Access Denied");
                    Console.WriteLine($"You have {3 - userattempts} attempts remaining.");
                    
                }
                else
                {
                    int passwordAttempts = 0;
                    while (passwordAttempts < 3)
                    {
                        Console.WriteLine("Enter your Password");
                        string password1 = Console.ReadLine();
                        if (password1 != password)
                        {
                            passwordAttempts++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Access Denied");
                            Console.WriteLine($"You have {3 - passwordAttempts} attempts remaining.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n                        ****************************************");
                            Console.WriteLine("                        *                                      *");
                            Console.WriteLine("                        *             Access Granted           *");
                            Console.WriteLine("                        *                                      *");
                            Console.WriteLine("                        ****************************************");
                            Console.ReadLine();
                            return;
                        }
                        
                    }
                    

                }
                


            }
        }
    }
}
//    Console.WriteLine("Enter your Password");
//                    if (password1 == password)
//                    {
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("Access Granted");
//                    }
//                    else if (password1 != password)
//{
//    attempts++;
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Access Denied");
//    Console.WriteLine($"You have {3 - attempts} attempts remaining.");
//}
//else if (userID != username)
//{
//    attempts++;
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Access Denied");
//    Console.WriteLine($"You have {3 - attempts} attempts remaining.");
//}
//else
//{
//    attempts++;
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Access Denied");
//    Console.WriteLine($"You have {3 - attempts} attempts remaining.");
//}
//                }