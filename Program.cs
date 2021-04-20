using System;

namespace RegisterBasic
{
    class Program
    {
        static string Info()
        {
            Console.WriteLine("write anything:");
            string text = Console.ReadLine();
            return text;
        }
        static string Register()
        {
            Console.WriteLine();
            Console.WriteLine("Register or Login?");
            Console.WriteLine("1- Register");
            Console.WriteLine("2- Login");
            Console.WriteLine("X- Leave");
            Console.WriteLine();

            string choose = Console.ReadLine();
            return choose;
        }
        static void Main(string[] args)
        {
            Database[] user = new Database[50];
            string choose = Register();
            var Allusers = 0;
            while (choose.ToUpper() != "X")
            {
                switch (choose)
                {
                    case "1":

                        Database users = new Database();
                        Console.WriteLine("Choose your Username");
                        string Name = Console.ReadLine().ToUpper();
                        users.UserName = Name;

                        Console.Clear();

                        Console.WriteLine("Your password:");
                        string password = Console.ReadLine().ToUpper();
                        users.Password = password;
                        Console.Clear();

                        user[Allusers] = users;
                        Allusers++;

                        break;
                    case "2":
                        bool verif = false, verifPass = false;
                        string verifUser, verifPW;
                        Console.WriteLine("Your Username:");
                        string loginUser = Console.ReadLine().ToUpper();
                        foreach (var a in user)
                        {
                            verifUser = a.UserName;
                            if (loginUser == verifUser)
                            {
                                verif = true;
                                if (verif = true)
                                {
                                    Console.WriteLine("Your password:");
                                    string loginpassword = Console.ReadLine().ToUpper();
                                    for (int i = 0; i < user.Length; i++)
                                    {
                                        if (loginpassword == a.Password)
                                        {
                                            verifPass = true;
                                        }
                                    }
                                }
                            }
                        }
                        Console.Clear();
                        if (verif == true && verifPass == true)
                        {
                            //logged
                            Console.WriteLine("logged");
                        }
                        else
                        {
                            Console.WriteLine("Username or Password wrong, try again");
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                choose = Register();
            }
        }
    }
}