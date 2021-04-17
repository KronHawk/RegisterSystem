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
            Console.WriteLine("Register or Login?");
            Console.WriteLine("1- Register");
            Console.WriteLine("2- Login");
            Console.WriteLine("X- Leave");

            string choose = Console.ReadLine();
            return choose;
        }
        static void Main(string[] args)
        {
            Database[] user = new Database[50];
            string choose = Register();
            while (choose.ToUpper() != "X")
            {
                switch (choose)
                {
                    case "1":

                        Database use;
                        Console.WriteLine("Choose your Username");
                        string Name = Console.ReadLine();
                        use.UserName = Name;

                        Console.Clear();

                        Console.WriteLine("Your password:");
                        string password = Console.ReadLine();
                        use.Password = password;
                        Console.Clear();

                        break;
                    case "2":
                        //building the simple system
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                choose = Register();
            }
        }
    }
}
